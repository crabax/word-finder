using System;

namespace WordFinderLib
{
    public class WordFinder
    {
        private readonly char[][] _matrix;
        public int TopMostRepeated { get; set; } = 10;

        public WordFinder(IEnumerable<string> matrix)
        {
            if (matrix.Count() > 64)
            {
                throw new ArgumentException(Consts.MATRIX_INVALID);
            }

            if (matrix.Any(m => m.Length > 64))
            {
                throw new ArgumentException(Consts.MATRIX_INVALID);
            }

            _matrix = matrix.Select(s => s.ToCharArray()).ToArray();
        }

        private static int ProcessRow(string wordToFind, char[] row)
        {
            var offset = 0;
            var timesFound = 0;

            for (int y = 0; y < row.Length; y++)
            {
                var wordIndex = y - offset;
                var isIndexInvalid = wordIndex >= wordToFind.Length;
                var isLastLetter = wordToFind.Length - 1 == wordIndex;

                var currentRowLetter = row[y];
                var remainingRowLetters = row.Length - (y + 1);
                var canContinueSearching = wordToFind.Length <= remainingRowLetters;

                if (isIndexInvalid || currentRowLetter != wordToFind[wordIndex])
                {
                    if (!canContinueSearching)
                    {
                        return timesFound;
                    }
                    else
                    {
                        //we do this to reset "wordIndex" so that we can search again "wordToFind"
                        offset++;
                    }
                }

                if (isLastLetter && currentRowLetter == wordToFind[wordIndex])
                {
                    //search "wordToFind" again in case there are more letters left in the current row
                    offset = y + 1;
                    timesFound++;
                    continue;
                }
            }
            return timesFound;
        }

        public IEnumerable<string> Find(IEnumerable<string> wordStream)
        {
            var wordsFound = new Dictionary<string, int>();
            foreach (var word in wordStream)
            {
                for (int x = 0; x < _matrix.Length; x++)
                {
                    var row = _matrix[x];
                    var timesFound = ProcessRow(word, row);
                    if (wordsFound.ContainsKey(word))
                    {
                        wordsFound[word] += timesFound;
                    }
                    else
                    {
                        wordsFound.Add(word, timesFound);
                    }
                }

                for (int x = 0; x < _matrix.Length; x++)
                {
                    var row = _matrix.Select(charArray => charArray[x]).ToArray();

                    var timesFound = ProcessRow(word, row);
                    if (wordsFound.ContainsKey(word))
                    {
                        wordsFound[word] += timesFound;
                    }
                    else
                    {
                        wordsFound.Add(word, timesFound);
                    }
                }
            }

            return wordsFound.Select(m => new 
            {
                Word = m.Key,
                Count = m.Value,
            })
            .Where(m => m.Count > 0)
            .OrderByDescending(m => m.Count)
            .ThenBy(m => m.Word)
            .Take(TopMostRepeated)
            .Select(m => m.Word)
            .ToList();
        }
    }
}