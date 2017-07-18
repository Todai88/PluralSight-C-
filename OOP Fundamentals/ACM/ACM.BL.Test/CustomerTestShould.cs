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
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            // -- Act 
            var expected = 3;
            var actual = Customer.InstanceCount;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnTrue_GivenAValidCustomer_WhenTestingValidate()
        {
            // -- Arrange

            var customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAddress = "Baggins@Baggins.me";

            var expected = true;

            // -- Act

            var actual = customer.Validate();

            // -- Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnFalse_GivenACustomerMissingEmail_WhenTestingValidate()
        {
            
            // -- Arrange

            var customer = new Customer();
            customer.LastName = "Baggins";

            var expected = false;

            // -- Act

            var actual = customer.Validate();

            // -- Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnFalse_GivenACustomerMissingLastName_WhenTestingValidate()
        {
            // -- Arrange

            var customer = new Customer();
            customer.EmailAddress = "Baggins@Baggins.me";

            var expected = false;

            // -- Act

            var actual = customer.Validate();

            // -- Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
