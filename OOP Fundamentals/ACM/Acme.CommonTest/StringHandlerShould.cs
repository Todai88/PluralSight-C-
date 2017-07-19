using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerShould
    {
        [TestMethod]
        public void ReturnASpaceSeparatedString_GivenCamelCasedString_WhenTestingInsertSpaces()
        {
            // -- Arrange

            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            // -- Act

            var actual = source.InsertSpaces();
            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnASingleSpaceSeparatedString_GivenCamelCasedStringWithExistingSpaces_WhenTestingInsertSpaces()
        {
            // -- Arrange

            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            // -- Act
            var actual = source.InsertSpaces();
            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
