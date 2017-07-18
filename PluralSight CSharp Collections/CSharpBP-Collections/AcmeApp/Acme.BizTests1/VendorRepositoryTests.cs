using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void GivenDifferentTypes_WhenTestingRetrieveType_ShouldReturnDifferentTypes()
        {
            // -- Arrange
            var repository = new VendorRepository();
            var expected = 42;

            // -- Act
            var actual = repository.RetrieveValue<decimal>("Select ...", 42);

            // -- Assert
            Assert.IsNotInstanceOfType(actual, expected.GetType());
        }

        [TestMethod()]
        public void GivenSameTypes_WhenTestingRetrieveType_ShouldReturnSameTypes()
        {
            // -- Arrange
            var repository = new VendorRepository();
            var expected = 42;

            // -- Act
            var actual = repository.RetrieveValue<int>("Select ...", 42);

            // -- Assert
            Assert.IsInstanceOfType(actual, typeof(int));
            Assert.IsInstanceOfType(expected, typeof(int));
        }

        [TestMethod()]
        public void Given42_WhenTestingRetrieveType_ShouldReturns42()
        {
            // -- Arrange
            var repository = new VendorRepository();
            var expected = 42;

            // -- Act
            var actual = repository.RetrieveValue<int>("Select ...", 42);

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenAString_WhenTestingRetrieveType_ShouldReturnsAString()
        {
            // -- Arrange
            var repository = new VendorRepository();
            var expected = "test";

            // -- Act
            var actual = repository.RetrieveValue<string>("Select ...", "test");

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNothing_WhenTestingRetrive_ReturnCount2()
        {
            var repository = new VendorRepository();
            var expected = 2;

            var actual = repository.Retrieve();

            Assert.AreEqual(expected, actual.ToList().Count);
        }

        [TestMethod]
        public void RetrieveTest()
        {
            // -- Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>();
            expected.Add(
            new Vendor()
            {
                VendorId = 1,
                CompanyName = "ABC Corp",
                Email = "abc@abc.com"
            });
            expected.Add(
            new Vendor()
            {
                VendorId = 2,
                CompanyName = "XYZ Inc",
                Email = "xyz@xyz.com"
            });

            // -- Act
            var actual = repository.Retrieve();
            // -- Assert
            CollectionAssert.AreEqual(expected, actual.ToList());

        }

        [TestMethod]
        public void GivenAnIterator_WhenTestingRetrieveWithIterator_AssertEqualTrue()
        {
            // -- Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>()
            {
            new Vendor()
                {
                    VendorId = 1,
                    CompanyName = "ABC Corp",
                    Email = "abc@abc.com"
                },
            new Vendor()
                {
                    VendorId = 2,
                    CompanyName = "XYZ Inc",
                    Email = "xyz@xyz.com"
                }
            };
            
            // -- Act
            var vendorIterator = repository.RetrieveWithIterator();
            foreach (var item in vendorIterator)
            {
                Debug.WriteLine(item);
            }
            var actual = vendorIterator.ToList();

            // -- Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenAListOfVendors_WhenTestingRetrieveAll_ReturnTrue()
        {
            // -- Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>();
            expected.Add(
                new Vendor()
                {
                    VendorId = 5,
                    CompanyName = "Amalgamated Toys",
                    Email = "abc@abc.com"
                });
            expected.Add(
                new Vendor()
                {
                    VendorId = 6,
                    CompanyName = "Toy Blocks Inc",
                    Email = "Blocks@abc.com"
                });
            expected.Add(
                new Vendor()
                {
                    VendorId = 8,
                    CompanyName = "Car Toys",
                    Email = "car@abc.com"
                });
            expected.Add(
                new Vendor()
                {
                    VendorId = 9,
                    CompanyName = "Toys for Fun",
                    Email = "fun@abc.com"
                });

            // -- Act
            var vendors = repository.RetrieveAll();
            var vendorQuery = vendors.Where(v => v.CompanyName.Contains("Toy"));
            // -- Assert
            CollectionAssert.AreEqual(expected, vendorQuery.ToList());
        }
        //[TestMethod]
        //public void GivenTwoSameVendorCollections_WhenTestingRetrive_AssertEqualTrue()
        //{
        //    var repository = new VendorRepository();
        //    var expected = new List<Vendor>();

        //expected.Add(
        //            new Vendor()
        //{
        //    VendorId = 1,
        //                CompanyName = "ABC Corp",
        //                Email = "abc@abc.com"
        //            });

        //    expected.Add(
        //        new Vendor()
        //        {
        //            VendorId = 2,
        //            CompanyName = "XYZ Inc",
        //            Email = "xyz@xyz.com"
        //        });

        //    var actual = repository.Retrieve();

        //    CollectionAssert.AreEqual(expected, actual);
        //}

        //[TestMethod()]
        //public void GivenVoidParameters_WhenTestingRetriveWithKeys_ReturnADictionaryOfVendors()
        //{
        //    var repository = new VendorRepository();
        //    var expected = new Dictionary<int, Vendor>()
        //                    {
        //        {1, new Vendor()
        //        {
        //            VendorId = 1,
        //            CompanyName = "ABC Corp",
        //            Email = "abc@abc.com"
        //        }},
        //        {2, new Vendor()
        //        {
        //            VendorId = 2,
        //            CompanyName = "XYZ Inc",
        //            Email = "xyz@xyz.com"
        //        }}
        //    };
        //    var actual = repository.RetrieveWithKey();

        //    CollectionAssert.AreEqual(expected, actual);
        //}
    }
}