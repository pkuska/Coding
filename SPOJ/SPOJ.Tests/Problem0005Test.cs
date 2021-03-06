using NUnit.Framework;

namespace SPOJ.Tests
{
    [TestFixture]
    public class Problem0005Test : ConsoleRedirectFixture
    {
        public Problem0005Test() : base(Problem0005.Main)
        {
        }

        [TestCase(new[] { 6, 808, 2133, 999, 9898, 98999, 979998 }, new[] { 818, 2222, 1001, 9999, 99099, 980089 })]
        public void MainTest(int[] input, int[] expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
