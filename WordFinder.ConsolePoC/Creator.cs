using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFinderConsolePoC
{
    public static class Creator
    {
        static readonly char[,] matrix = new char[64, 64];

        public static void Do()
        {
            // words to include in the matrix
            string[] words =
            {
                "arch", "bird", "clay", "dusk", "echo", "girl", "hope", "iris", "jade", "knot",
                "lava", "moon", "nest", "onyx", "pear", "quay", "rain", "sand", "tusk", "vase"
            };

            foreach (string word in words)
            {
                InsertWord(word);
            }

            // fill "blank" spaces
            FillMatrix();

            // print it so you can copy the generated matrix
            PrintMatrix();
        }

        static void InsertWord(string word)
        {
            var random = new Random();

            // calculate the direction in which we want to insert the word
            int direction = random.Next(2);

            // calculate the position in which we want to insert the word
            int x = random.Next(matrix.GetLength(0) - (word.Length * (1 - direction)));
            int y = random.Next(matrix.GetLength(1) - (word.Length * direction));

            // insert the word
            for (int i = 0; i < word.Length; i++)
            {
                matrix[x + (i * (1 - direction)), y + (i * direction)] = word[i];
            }
        }

        static void FillMatrix()
        {
            var random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == '\0')
                    {
                        // uncomment this if you want actual random words
                        //matrix[i, j] = (char)random.Next('a', 'z' + 1);
                        matrix[i, j] = 'f';
                    }
                }
            }
        }

        static void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "");
                }
                Console.WriteLine();
            }
        }
    }
}
