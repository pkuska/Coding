using NUnit.Framework;

namespace SPOJ.Tests
{
    [TestFixture]
    public class Problem042Test : ConsoleRedirectFixture
    {
        public Problem042Test() : base(Problem042.Main)
        {
        }

        [TestCase(new object[] { 3, new[] { 24, 1 }, new[] { 4358, 754 }, new[] { 305, 794 } }, new[] { 34, 1998, 1 })]
        public void MainTest(object[] input, int[] expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
