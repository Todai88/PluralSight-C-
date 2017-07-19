using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.CommonTest
{
    [TestClass]
    public class LogginServiceShould
    {

        [TestMethod]
        public void ReturnNothingButPrintLinesToConsole_GivenTwoCustomerObjects_WhenTestingWriteToFile()
        {
            // -- Arrange
            var changedItems = new List<ILoggable>();
            // -- Act
            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription= "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);
            LoggingService.WriteToFile(changedItems);

            // -- Assert      
            // Nothing to test.
        }
    }
}
