using NUnit.Framework;

namespace SPOJ.Tests
{
    [TestFixture]
    public class Problem011Test : ConsoleRedirectFixture
    {
        public Problem011Test() : base(Problem011.Main)
        {
        }

        [TestCase(new[] { 6, 3, 60, 100, 1024, 23456, 8735373 }, new[] { 0, 14, 24, 253, 5861, 2183837 })]
        public void MainTest(int[] input, int[] expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
