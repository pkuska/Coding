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
        [TestCase(new object[] { 2, new[] { 1, 10 }, new[] { 3, 5 } }, new object[] { 2, 3, 5, 7, "", 3, 5 })]
        public void MainTest(object[] input, object[] expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
