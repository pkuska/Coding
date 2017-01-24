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
    public partial class Problem001Test
    {
        [PexMethod]
        public void MainTest()
        {
            Problem001.Main();
            // TODO: add assertions to method Problem001Test.MainTest()
        }
    }
}
