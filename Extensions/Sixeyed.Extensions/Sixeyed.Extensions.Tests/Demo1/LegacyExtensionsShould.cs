using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Samples.Demo1;

namespace Sixeyed.Extensions.Tests
{
    [TestClass]
    public class LegacyExtensionsShould
    {
        [TestMethod]
        public void Return0201231_WhenToLegacyFormat_Given1920_12_31()
        {
            // -- Arrange
            var actual = new DateTime(1920, 12, 31);

            // -- Act
            var expected = "0201231";

            // -- Assert
            Assert.AreEqual(expected, actual.ToLegacyFormat());
        }

        [TestMethod]
        public void Return1131031_Given2013_10_31_ToToLegacyFormat()
        {
            // -- Arrange
            var actual = new DateTime(2013, 10, 31);

            // -- Act
            var expected = "1131031";

            // -- Assert
            Assert.AreEqual(expected, actual.ToLegacyFormat());
        }

        [TestMethod]
        public void ReturnBAJOULJOAKIM_GivenJoakimBajoul_ToToLegacyFormat()
        {
            // -- Arrange
            var name = "Joakim Bajoul";
            var expected = "BAJOUL, JOAKIM";

            // -- Act
            var actual = name.ToLegacyFormat();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
