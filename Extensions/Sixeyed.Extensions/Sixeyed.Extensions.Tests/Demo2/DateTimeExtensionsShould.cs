using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;

namespace Sixeyed.Extensions.Tests.Demo2
{
    [TestClass]
    public class DateTimeExtensionsShould
    {
        [TestMethod]
        public void ReturnCorrectXML_GivenACorrectDateTime_ToXMLDateTime()
        {
            // -- Arrange
            var datetime = new DateTime(2013, 10, 24, 13, 10, 15, 951);
            var expected = "2013-10-24T13:10:15.951Z";

            // -- Act
            var actual = datetime.ToXmlDateTime();
            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnCorrectXML_GivenACorrectDateTimeAndLocal_ToXMLDateTime()
        {
            // -- Arrange
            var datetime = new DateTime(2013, 10, 24, 13, 10, 15, 951);
            var expected = "2013-10-24T13:10:15.951+01:00";

            // -- Act
            var actual = datetime.ToXmlDateTime(mode: XmlDateTimeSerializationMode.Local);
            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
