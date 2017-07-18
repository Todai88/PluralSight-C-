using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Test
{
    [TestClass]
    public class InvoiceRepositoryTest
    {
        public InvoiceRepository invoiceRepository;
        public TestContext TestContext { get; set; } 

        /// <summary>
        /// Setup and Teardown
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        { 
            this.invoiceRepository = new InvoiceRepository();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.invoiceRepository = null;
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestCalculateTotalAmountInvoiced()
        {
            var invoiceList = invoiceRepository.Retrieve(); 
            var actual = invoiceRepository.CalculateTotalAmountInvoiced(invoiceList);

            Assert.AreEqual(1333.14M, actual);
        }

        [TestMethod]
        public void TestCalculateTotalUnitsSold()
        {
            var invoiceList = invoiceRepository.Retrieve();
            var actual = invoiceRepository.CalculateTotalUnitsSold(invoiceList);

            Assert.AreEqual(136, actual);
        }

    }
}
