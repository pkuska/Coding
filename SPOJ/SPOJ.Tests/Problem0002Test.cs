using NUnit.Framework;

namespace SPOJ.Tests
{
    [TestFixture]
    public class Problem0002Test : ConsoleRedirectFixture
    {
        public Problem0002Test() : base(Problem0002.Main)
        {
        }

        [TestCase(new object[] { 2, new[] { 1, 10 }, new[] { 3, 5 } }, new object[] { 2, 3, 5, 7, "", 3, 5 })]
        public void MainTest(object[] input, object[] expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
