using NUnit.Framework;

namespace SPOJ.Tests
{
    [TestFixture]
    public class Problem0011Test : ConsoleRedirectFixture
    {
        public Problem0011Test() : base(Problem0011.Main)
        {
        }

        [TestCase(new[] { 6, 3, 60, 100, 1024, 23456, 8735373 }, new[] { 0, 14, 24, 253, 5861, 2183837 })]
        public void MainTest(int[] input, int[] expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
