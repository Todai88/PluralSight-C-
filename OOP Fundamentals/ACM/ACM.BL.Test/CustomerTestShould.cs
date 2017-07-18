using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerTestShould
    {
        [TestMethod]
        public void ReturnJoakimBajoul_GivenFirstNameJoakimAndLastNameBajoul_WhenTestingFullName()
        {
            // -- Arrange
            var customer = new Customer();
            customer.FirstName = "Joakim";
            customer.LastName = "Bajoul";

            var expected = "Bajoul, Joakim";

            // -- Act
            var actual = customer.FullName;

            // -- Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnBajoul_GivenEmptyFirstNameAndLastNameBajoul_WhenTestingFullName()
        {
            // -- Arrange
            var customer = new Customer(); 
            customer.LastName = "Bajoul";

            var expected = "Bajoul";

            // -- Act
            var actual = customer.FullName;

            // -- Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnJoakim_GivenFirstNameJoakimAndEmptyLastName_WhenTestingFullName()
        {
            // -- Arrange
            var customer = new Customer();
            customer.FirstName = "Joakim"; 

            var expected = "Joakim";

            // -- Act
            var actual = customer.FullName;

            // -- Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Return3_GivenThreeInstancesOfCustomer_WhenTestingInstanceCount()
        {
            // -- Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";

            var c2 = new Customer();
            c2.FirstName = "Frodo";

            var c3 = new Customer();
            c3.FirstName = "Rosie";

            // -- Act 
            var expected = 3;
            var actual = Customer.InstanceCount;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
