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
    public class Problem011Test : ConsoleRedirectFixture
    {
        public Problem011Test() : base(Problem011.Main)
        {
        }

        [PexMethod]
        [TestCase(new[] { 6, 3, 60, 100, 1024, 23456, 8735373 }, new[] { 0, 14, 24, 253, 5861, 2183837 })]
        public void MainTest(int[] input, int[] expectedOutput)
        {
            InputOutputTest(input, expectedOutput);
        }
    }
}
