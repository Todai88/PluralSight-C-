using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Advanced.Demo3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixeyed.Extensions.Advanced.Tests.Demo3
{
    [TestClass]
    public class DateTimeExtensionsShould
    {

        [TestMethod]
        public void ReturnXmlDateTime_GivenADateTime_WhenTestingToXmlDateTime()
        {
            
            var actual = DateTimeExtensions.ToXmlDateTime(new DateTime(2013, 10, 24));
            var expected = new DateTime(2013, 10, 24).ToXmlDateTime();

            Assert.AreEqual(expected, actual);
        }
    }
}
