using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Samples.Demo3;
using Sixeyed.Extensions.Samples.Demo3.Impl;
using System.Linq;

namespace Sixeyed.Extensions.Tests.Demo3
{
    [TestClass]
    public class ReferenceDataSourceShould
    {
        private IReferenceDataSource _source;
        
        [TestInitialize]
        public void TestInitialize()
        {
            
        }
        [TestMethod]
        public void Return2_GivenApiDataSource_WhenTestingGetItems()
        {
            _source = new ApiReferenceDataSource();
            Assert.AreEqual(2, _source.GetItems().Count());
        }

        [TestMethod]
        public void Return2_GivenXmlDataSource_WhenTestingGetItems()
        {
            _source = new XmlReferenceDataSource();
            Assert.AreEqual(2, _source.GetItems().Count());
        }

        [TestMethod]
        public void Return2_GivenSqlDataSource_WhenTestingGetItems()
        {
            _source = new SqlReferenceDataSource();
            Assert.AreEqual(2, _source.GetItems().Count());
        }

        [TestMethod]
        public void Return2_GivenApiDataSource_WhenTestingGetItemsByCodexyz()
        {
            _source = new ApiReferenceDataSource();
            Assert.AreEqual(2, _source.GetItemsByCode("xyz").Count());
        }

    }
}
