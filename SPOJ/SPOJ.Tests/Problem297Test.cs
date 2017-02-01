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
    public class Problem297Test : ConsoleRedirectFixture
    {
        public Problem297Test() : base(Problem297.Main)
        {
        }


        [PexMethod]
        [TestCase(new object[] { 1, new[] { 5, 3 }, 1, 2, 8, 4, 9 }, 3)]
        public void MainTest(object[] input, int expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
