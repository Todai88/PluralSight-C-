using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Samples.Demo3.Impl;
using Sixeyed.Extensions.Samples.Demo3;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Sixeyed.Extensions.Tests.Demo4
{
    [TestClass]
    public class ReferenceDataSourceCollectionsExtensionsShould
    {
        [TestMethod]
        public void Return6_Given3Arrays_WhenTestingGetAllItemsByCode()
        {
            var sources = new IReferenceDataSource[]
            {
                new SqlReferenceDataSource(),
                new XmlReferenceDataSource(),
                new ApiReferenceDataSource()
            };

            var expected = 6;
            var actual = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(expected, actual.Count());
        }

        [TestMethod]
        public void Return6_GivenAnArrayListWithObjectsAndStrings_WhenTestingGetAllItemsByCode()
        {
            var sources = new ArrayList()
            {
                new SqlReferenceDataSource(),
                new XmlReferenceDataSource(),
                new ApiReferenceDataSource()
            };
            sources.Add("Hi, I'm a string");

            var expected = 6;
            var actual = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(expected, actual.Count());
        }

        [TestMethod]
        public void Return0_GivenOnlyStrings_WhenTestingGetAllItemsByCode()
        {
            var sources = new ArrayList();
            sources.Add("Hi, I'm a string");
            sources.Add("I'm a string too!");
            sources.Add("Me too!!!!");
            sources.Add(32);

            var expected = 0;
            var actual = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(0, actual.Count());
        }

        [TestMethod]
        public void Return6_GivenAnIReferenceDataSource_WhenTestingGetAllItemsByCode()
        {
            var sources = new HashSet<IReferenceDataSource>
            {
                new SqlReferenceDataSource(),
                new XmlReferenceDataSource(),
                new ApiReferenceDataSource()
            }; 

            var expected = 6;
            var actual = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(expected, actual.Count());
        }
    }
}
