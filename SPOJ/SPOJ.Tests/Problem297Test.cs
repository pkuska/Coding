using NUnit.Framework;

namespace SPOJ.Tests
{
    [TestFixture]
    public class Problem297Test : ConsoleRedirectFixture
    {
        public Problem297Test() : base(Problem297.Main)
        {
        }

        [TestCase(new object[] { 1, new[] { 5, 3 }, 1, 2, 8, 4, 9 }, 3)]
        public void MainTest(object[] input, int expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
