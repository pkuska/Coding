using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;

namespace SPOJ.Tests
{
    [PexClass(typeof(Problem001))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public class Problem001Test : ConsoleRedirectFixture
    {
        public Problem001Test() : base(Problem001.Main)
        {
        }

        [PexMethod]
        [TestCase(new[] { 1, 2, 3, 42 }, new[] { 1, 2, 3 })]
        [TestCase(new[] { 1, 2, 3, 42, 5 }, new[] { 1, 2, 3 })]
        public void MainTest(int[] input, int[] expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
