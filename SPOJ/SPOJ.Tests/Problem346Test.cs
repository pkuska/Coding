using NUnit.Framework;

namespace SPOJ.Tests
{
    [TestFixture]
    public class Problem346Test : ConsoleRedirectFixture
    {
        public Problem346Test() : base(Problem346.Main)
        {
        }

        [TestCase(12, 13)]
        [TestCase(2, 2)]
        [TestCase(0, 0)]
        public void MainTest(int input, int expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
