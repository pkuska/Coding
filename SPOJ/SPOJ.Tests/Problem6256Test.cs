using NUnit.Framework;

namespace SPOJ.Tests
{
    [TestFixture]
    public class Problem6256Test : ConsoleRedirectFixture
    {
        public Problem6256Test() : base(Problem6256.Main)
        {
        }

        [TestCase(new object[] { 3, "", 3, 3, 1, 2, "", 5, 2, 3, 8, 6, 1, "", 10, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new[] { 2, 5, 45 })]
        [TestCase(new object[] { 1, "", 6, 1, 2, 3, 3, 2, 1 }, new[] { 6 })]
        public void MainTest(object[] input, int[] expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
