using NUnit.Framework;

namespace SPOJ.Tests
{
    [TestFixture]
    public class Problem0001Test : ConsoleRedirectFixture
    {
        public Problem0001Test() : base(Problem0001.Main)
        {
        }

        [TestCase(new[] { 1, 2, 3, 42 }, new[] { 1, 2, 3 })]
        [TestCase(new[] { 1, 2, 3, 42, 5 }, new[] { 1, 2, 3 })]
        public void MainTest(int[] input, int[] expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
