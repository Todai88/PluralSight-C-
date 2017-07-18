using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorTests
    {
        [TestMethod()]
        public void SendEmailTest()
        {
            var vendorRepository = new VendorRepository();
            var vendors = vendorRepository.Retrieve();
            var expected = new List<string>()
            {
                "Message sent: Important message for: ABC Corp",
                "Message sent: Important message for: XYZ Inc"
            };

            var actual = Vendor.SendEmail(vendors.ToList(), "Test Message");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SendEmailTestArray()
        {
            var vendorRepository = new VendorRepository();
            var vendors = vendorRepository.Retrieve();
            var expected = new List<string>()
            {
                "Message sent: Important message for: ABC Corp",
                "Message sent: Important message for: XYZ Inc"
            };

            var actual = Vendor.SendEmail(vendors.ToList(), "Test Message");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenTwoEqualDictionaries_WhenTestRetrive_ReturnAssertEqualTrue()
        {
            var repository = new VendorRepository();
            var vendorsCollection = repository.Retrieve();

            var expected = new List<string>()
            {
                "Message sent: Important message for: ABC Corp",
                "Message sent: Important message for: XYZ Inc"
            };
            var vendors = vendorsCollection.ToDictionary(v => v.VendorId);
            var actual = Vendor.SendEmail(vendors.Values, "Test Message");
            CollectionAssert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void SendEmailTestAdd()
        //{
        //    // -- Arrange
        //    var repository = new VendorRepository();
        //    var vendorCollection = repository.Retrieve();
        //    vendorCollection.Add(new Vendor()
        //    { VendorId = 3, CompanyName = "EFG Ltd", Email = "efg@efg.com" });

        //    var vendorMaster = repository.Retrieve();

        //    var expected = new List<string>()
        //    {
        //        "Message sent: Important message for: ABC Corp",
        //        "Message sent: Important message for: XYZ Inc"
        //    };
        //    var vendors = vendorCollection.ToList();

        //    // -- Act
        //    var actual = Vendor.SendEmail(vendors, "Test Message");
        //    // -- Assert
        //    CollectionAssert.AreEqual(expected, actual);
        //}
    }
}