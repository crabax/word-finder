using System.Diagnostics;
using System.Linq;
using WordFinderLib;
using Consts = WordFinderTest.Consts;

namespace WordFinderConsolePoC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var wordFinder = new WordFinder(Consts.Matrix5x5);
            var found = wordFinder.Find(new List<string>
            {
                "cold",
                "wind",
                "snow",
                "chill",
            });

            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            Console.WriteLine($"{nameof(Consts.Matrix5x5)} found: {string.Join(", ", found)} in {elapsedTime.TotalSeconds} seconds ({elapsedTime.TotalMilliseconds} ms)");

            stopwatch.Start();
            wordFinder = new WordFinder(Consts.Matrix15x15)
            {
                TopMostRepeated = 2
            };
            found = wordFinder.Find(new List<string>
            {
                "cold",
                "wind",
                "snow",
                "chill",
                "chart",
            });

            stopwatch.Stop();
            elapsedTime = stopwatch.Elapsed;
            Console.WriteLine($"{nameof(Consts.Matrix15x15)} found: {string.Join(", ", found)} in {elapsedTime.TotalSeconds} seconds ({elapsedTime.TotalMilliseconds} ms)");

            stopwatch.Start();
            wordFinder = new WordFinder(Consts.Matrix64x64)
            {
                TopMostRepeated = 3
            };
            found = wordFinder.Find(new List<string>
            {
                "cold",
                "wind",
                "snow",
                "chill",
                "cart"
            });

            stopwatch.Stop();
            elapsedTime = stopwatch.Elapsed;
            Console.WriteLine($"{nameof(Consts.Matrix64x64)} found: {string.Join(", ", found)} in {elapsedTime.TotalSeconds} secods ({elapsedTime.TotalMilliseconds} ms)");

            stopwatch.Start();
            wordFinder = new WordFinder(Consts.Matrix64x64_v2)
            {
                TopMostRepeated = 20
            };
            found = wordFinder.Find(new List<string>
            {
                "arch", "bird", "clay", "dusk", "echo", "girl", "hope", "iris", "jade", "knot",
                "lava", "moon", "nest", "onyx", "pear", "quay", "rain", "sand", "tusk", "vase"
            });

            stopwatch.Stop();
            elapsedTime = stopwatch.Elapsed;
            Console.WriteLine($"{nameof(Consts.Matrix64x64)} found: {string.Join(", ", found)} in {elapsedTime.TotalSeconds} secods ({elapsedTime.TotalMilliseconds} ms)");

        }
    }
}