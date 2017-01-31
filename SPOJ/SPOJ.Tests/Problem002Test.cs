using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;

namespace SPOJ.Tests
{
    [TestFixture]
    [PexClass(typeof(Problem002))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public class Problem002Test : ConsoleRedirectFixture
    {
        public Problem002Test() : base(Problem002.Main)
        {
        }

        [PexMethod]
        [TestCase(new[] { "2", "1 10", "3 5" }, new[] {"2", "3", "5", "7", "", "3", "5"})]
        public void MainTest(string[] input, string[] expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
