using ACM.BL;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void GivenValidValues_WhenCalculatePercentOfGoalSteps_ThenCorrectValueReturned()
        {
            // -- Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "2000";
            decimal expected = 40.0M;

            // -- Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenValidAndSameValues_WhenCalculatePercentOfGoalSteps_ThenCorrectValueReturned()
        {
            // -- Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "5000";
            decimal expected = 100.0M;

            // -- Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);
            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenCorrectValueTypesAndActual0_WhenCalculatePercentOfGoalSteps_Then0Returned()
        {
            // -- Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "0";
            decimal expected = 0M;

            // -- Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GivenGoalIsNull_WhenCalcululatePercentOfGoalSteps_ThenThrowArgumentException()
        {
            // -- Arrange
            var customer = new Customer();
            string goalSteps = null;
            string actualSteps = "2000";

            // -- Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);
            // -- Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GivenGoalIsNotNumeric_WhenCalculatePercentOfGoalSteps_ThenThrowArgumentException()
        {
            // -- Arranage
            var customer = new Customer();
            string goalSteps = "fivethousand";
            string actualSteps = "2000";

            // -- Act
            try
            {
                var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Goal must be numeric", ex.Message);
                throw;
            }
            
        }
    }
}
