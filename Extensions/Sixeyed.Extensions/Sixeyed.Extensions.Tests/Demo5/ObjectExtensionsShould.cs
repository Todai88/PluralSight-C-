using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Samples.Demo3;
using System.Collections.Generic;
using Sixeyed.Extensions.Samples.Demo3.Impl;
using System.Diagnostics;
using Sixeyed.Extensions.Samples.Demo5;

namespace Sixeyed.Extensions.Tests.Demo5
{
    [TestClass]
    public class ObjectExtensionsShould
    {
        [TestMethod]
        public void ReturnJsonObjects_GivenDataTypes_WhenTestingToJsonString()
        {
            var integerObject = int.MaxValue;
            var dateTimeObject = new DateTime(2000, 12, 31);
            var referenceDataItemObject = new ReferenceDataItem
            {
                Code = "xyz",
                Description = "123"
            };
            var enumerableInterfaceObject = new List<IReferenceDataSource>
            {
                new SqlReferenceDataSource()
            };
            Debug.WriteLine("Obj1: " + integerObject.ToJsonString());
            Debug.WriteLine("Obj2: " + dateTimeObject.ToJsonString());
            Debug.WriteLine("Obj3: " + referenceDataItemObject.ToJsonString());
            Debug.WriteLine("Obj4: " + enumerableInterfaceObject.ToJsonString());
        }

        [TestMethod]
        public void ReturnJsonObjects_GivenTypeDescriptions_WhenTestingTypeGetDescription()
        {
            var integerObject = int.MaxValue;
            var dateTimeObject = new DateTime(2000, 12, 31);
            var referenceDataItemObject = new ReferenceDataItem
            {
                Code = "xyz",
                Description = "123"
            };
            var enumerableInterfaceObject = new List<IReferenceDataSource>
            {
                new SqlReferenceDataSource()
            };
            Debug.WriteLine("Obj1: " + integerObject.GetJsonTypeDescription());
            Debug.WriteLine("Obj2: " + dateTimeObject.GetJsonTypeDescription());
            Debug.WriteLine("Obj3: " + referenceDataItemObject.GetJsonTypeDescription());
            Debug.WriteLine("Obj4: " + enumerableInterfaceObject.GetJsonTypeDescription());
        }
    }
}
