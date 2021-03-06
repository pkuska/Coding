using System.Numerics;
using NUnit.Framework;

namespace SPOJ.Tests
{
    [TestFixture]
    public class Problem0004Test : ConsoleRedirectFixture
    {
        public Problem0004Test() : base(Problem0004.Main)
        {
        }

        [TestCase(new object[] { 3, "(a+(b*c))", "((a+b)*(z+x))", "((a+t)*((b+(a+c))^(c+d)))" }, new[] { "abc*+", "ab+zx+*", "at+bac++cd+^*" })]
        public void MainTest(object[] input, string[] expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
