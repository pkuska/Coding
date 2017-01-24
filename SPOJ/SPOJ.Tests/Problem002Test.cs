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
    public partial class Problem002Test
    {

        [PexMethod]
        public void MainTest()
        {
            Problem002.Main();
            // TODO: add assertions to method Problem002Test.MainTest()
        }
    }
}
