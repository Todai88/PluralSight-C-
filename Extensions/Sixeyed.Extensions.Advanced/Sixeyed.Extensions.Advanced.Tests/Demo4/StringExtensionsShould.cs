using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixeyed.Extensions.Advanced.Tests.Demo4
{
    [TestClass]
    public class StringExtensionsShould
    {
        [TestMethod]
        public void ReturnAFormattedString_GivenAString_WhenTestingFormatWith()
        {
            var actual = "Demo {0}".FormatWith(4);
            var expected = "Demo 4";

            Assert.AreEqual(expected, actual);
        }
    }
}
