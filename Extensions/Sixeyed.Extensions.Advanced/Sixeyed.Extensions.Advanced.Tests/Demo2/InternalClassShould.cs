using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Advanced.Demo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sixeyed.Extensions.Advanced.Tests.Demo2
{
    [TestClass]
    public class InternalClassShould
    {
        [TestMethod]
        public void Returnabc_GivenClass0_WhenTestingGetString0()
        {
            var obj = new Class1();
            Assert.AreEqual("abc", obj.GetString0());
        }

        [TestMethod]
        public void ReturnABC_GivenClass0_WhenTestingGetString0Upper()
        {
            var obj = new Class1();
            Assert.AreEqual("ABC", obj.GetString0Upper());
        }

        [TestMethod]
        public void Returna_GivenAnExtendedClass1_WhenTestingGetString1Extension()
        {
            var obj1 = new Class1();
            Assert.AreEqual("a", obj1.GetString1());
            Assert.AreEqual("A", obj1.GetString1Upper());
        }

        [TestMethod]
        public void Returnxyz_GivenAnClass2ExtensionOfClass0_WhenTestingGetString0()
        {
            var obj2 = new Class1.Class2();
            Assert.AreEqual("xyz", obj2.GetString0());
            Assert.AreEqual("XYZ", obj2.GetString0Upper());
        }

        [TestMethod]
        public void Returna_GivenAnExtendedClass2_WhenTestingGetString2Extension()
        {
            var obj2 = new Class1.Class2();
            Assert.AreEqual("b", obj2.GetString2());
            Assert.AreEqual("B", obj2.GetString2Upper());
        }

        [TestMethod]
        public void Returna_GivenANewClass1_WhenTestingComparison()
        {
            var obj1 = new Class1();
            Assert.AreEqual("a", obj1.GetString1());
        }

        [TestMethod]
        public void Returnb_GivenANewClass2_WhenTestingComparison()
        {
            var obj2 = new Class1.Class2();
            Assert.AreEqual("b", obj2.GetString2());
        }

        [TestMethod]
        public void Returnc_GivenANewClass3_WhenTestingComparison()
        {
            var type3 = typeof(Class1.Class2).GetNestedType("Class3", BindingFlags.NonPublic);
            var methodInfo = type3.GetMethod("GetString3", BindingFlags.NonPublic | BindingFlags.Instance);
            var obj3 = Activator.CreateInstance(type3);
            Assert.AreEqual("c", methodInfo.Invoke(obj3, null));
            Assert.AreEqual("C", obj3.GetString3Upper());
        } 
    }
}
