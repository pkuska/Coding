using NUnit.Framework;

namespace SPOJ.Tests
{
    [TestFixture]
    public class Problem0024Test : ConsoleRedirectFixture
    {
        public Problem0024Test() : base(Problem0024.Main)
        {
        }

        [TestCase(new[] { 5, 1, 2, 5, 3, 100 }, new object[] { 1, 2, 120, 6, "93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000" })]
        public void MainTest(int[] input, object[] expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
