using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        public TestContext Testcontext { get; set; }
        public List<Customer> customerList { get; set; }
        public List<CustomerType> customerTypeList { get; set; }

        CustomerRepository repository;
        CustomerTypeRepository typeRespository;

        [TestInitialize]
        public void TestInitialize()
        {
            this.repository       = new CustomerRepository();
            this.typeRespository  = new CustomerTypeRepository();
            this.customerList     = repository.Retrieve();
            this.customerTypeList = typeRespository.Retrieve();
        }

        [TestMethod]
        public void TestFoundExistingCustomer()
        {
            var result = this.repository.Find(this.customerList, 2);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestCompareCustomerId()
        {
            var result = this.repository.Find(this.customerList, 2);
            Assert.AreEqual(2, result.CustomerId);
        }

        [TestMethod]
        public void TestCompareCorrectFirstName()
        {
            var result = this.repository.Find(this.customerList, 2);
            Assert.AreEqual("Bilbo", result.FirstName);
        }

        [TestMethod]
        public void TestCompareIncorrectFirstName()
        {
            var result = this.repository.Find(this.customerList, 1);
            Assert.AreNotEqual("Bilbo", result.FirstName);
        }
        [TestMethod]
        public void TestFindNotFound()
        {
            var result = this.repository.Find(this.customerList, 42);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestCorrectIndexFromSortByName()
        {
            var result = this.repository.SortByName(this.customerList);
            Assert.AreEqual("Baggins", result.First().LastName);
            Assert.AreEqual("Bilbo", result.First().FirstName);
        }

        [TestMethod]
        public void TestIncorrectIndexFromSortByName()
        {
            var result = this.repository.SortByName(this.customerList);
            Assert.AreNotEqual("Gamgee", result.First().LastName);
        }

        [TestMethod]
        public void TestCorrectIndexFromReversedSortByName()
        {
            var result = this.repository.SortByNameInReverse(this.customerList);
            Assert.AreEqual("Bilbo", result.Last().FirstName);
            Assert.AreEqual("Baggins", result.Last().LastName);
        }

        [TestMethod]
        public void TestIncorrectIndexFromReversedSortByName()
        {
            var result = this.repository.SortByNameInReverse(this.customerList);
            Assert.AreNotEqual("Gamgee", result.Last().LastName);
        }

        [TestMethod]
        public void TestIndexOfLastAfterSortByTypeId()
        {
            var result = this.repository.SortByType(this.customerList);
            Assert.IsNull(result.Last().CustomerTypeId);
        }

        [TestMethod]
        public void TestIndexOfFirstAfterSortByTypeId()
        {
            var result = this.repository.SortByType(this.customerList);
            Assert.IsInstanceOfType(result.First().CustomerTypeId, typeof(int?));
        }
        [TestCleanup]
        public void TestCleanup()
        {
            this.Testcontext = null;
            this.customerList = null;
        }

        [TestMethod]
        public void TestGetNames()
        {
            var result = this.repository.GetNames(this.customerList);

            foreach(var item in result)
            {
                Debug.WriteLine(item.ToString());
            }

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestGetNamesAndEmail()
        {
            var result = this.repository.GetNamesAndEmails(this.customerList);

            //Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestGetNameAndType()
        {
            var result = this.repository.GetNamesAndTypes(this.customerList,
                                                          this.customerTypeList);

            //Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestOverdueCustomers() 
        {
            var custList = this.repository.Retrieve();
            var query = this.repository.GetOverdueCustomers(custList);
             
            foreach(var item in query)
            {
                Debug.WriteLine(item.LastName + ", " + item.FirstName);
            } 

            Assert.IsNotNull(query);
        }
    }
}
