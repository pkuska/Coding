using NUnit.Framework;

namespace SPOJ.Tests
{
    [TestFixture]
    public class Problem0394Test : ConsoleRedirectFixture
    {
        public Problem0394Test() : base(Problem0394.Main)
        {
        }

        [TestCase(new[] { "25114", "1111111111", "3333333333", "20202", "201011", "110", "0" }, new[] { 6, 89, 1, 1, 2, 1 })]
        public void MainTest(string[] input, int[] expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
