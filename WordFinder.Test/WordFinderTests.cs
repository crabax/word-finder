using Shouldly;

namespace WordFinderTest
{
    public class WordFinderTests
    {
        [Fact]
        public void Find_5x5_ReturnsWordsFound()
        {
            //arrage
            var wordFinder = new WordFinder(Consts.Matrix5x5);
            var wordStream = new List<string>
            {
                "cold",
                "wind",
                "snow",
                "chill",
            };
            var expected = new List<string>
            {
                "cold",
                "wind",
                "chill",
            };

            //act
            var found = wordFinder.Find(wordStream);

            //asset
            found.Count(m => expected.Contains(m)).ShouldBe(expected.Count);
        }

        [Fact]
        public void Find_15x15_ReturnsTop2WordsFound()
        {
            //arrage
            var wordFinder = new WordFinder(Consts.Matrix15x15)
            {
                TopMostRepeated = 2
            };

            var wordStream = new List<string>
            {
                "cold",
                "wind",
                "snow",
                "chill",
                "chart",
            };
            var expected = new List<string>
            {
                "chart",
                "chill",
            };

            //act
            var found = wordFinder.Find(wordStream);

            //asset
            found.Count(m => expected.Contains(m)).ShouldBe(expected.Count);
        }

        [Fact]
        public void Find_64x64_ReturnsTop3WordsFound()
        {
            //arrage
            var wordFinder = new WordFinder(Consts.Matrix64x64)
            {
                TopMostRepeated = 3
            };

            var wordStream = new List<string>
            {
                "cold",
                "wind",
                "snow",
                "chill",
                "cart"
            };

            var expected = new List<string>
            {
                "snow",
                "chill",
                "wind",
            };

            //act
            var found = wordFinder.Find(wordStream);

            //asset
            found.Count(m => expected.Contains(m)).ShouldBe(expected.Count);
        }
    }
}