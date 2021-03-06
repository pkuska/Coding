using NUnit.Framework;

namespace SPOJ.Tests
{
    [TestFixture]
    public class Problem0006Test : ConsoleRedirectFixture
    {
        public Problem0006Test() : base(Problem0006.Main)
        {
        }

        [TestCase(new[] { "5", "12345+67890", "324-111", "325*4405", "1234*4", "101-2" },
            new[] { " 12345", "+67890", "------", " 80235", "",
                " 324", "-111", "----", " 213", "",
                "    325", "  *4405", "  -----", "   1625", "     0 ", " 1300  ", "1300   ", "-------", "1431625", "",
                "1234", "  *4", "----", "4936", "",
                "101", " -2", " --", " 99", ""})]
        [TestCase(new[] { "1", "1*999" }, new[] { "   1", "*999", "----", "   9", "  9 ", " 9  ", " ---", " 999", "" })]
        public void MainTest(string[] input, string[] expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
