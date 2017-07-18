using ACM.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Library.Test
{
    [TestClass]
    public class BuilderTest
    { 
        public TestContext TestContext { get; set; }

        public Builder listBuilder { get; set; }

        [TestInitialize]
        public void TestInitialize ()
        {
            this.listBuilder = new Builder();
        }

        [TestMethod]
        public void TestBuildIntegerSequence()
        {
            var result = listBuilder.BuildIntegerSequence();

            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }

            Assert.IsNotNull(result);
            TestContext.WriteLine("Test");
        }

        [TestMethod]
        public void TestCompareSequences()
        {
            var result = listBuilder.CompareSequence();
            
            foreach(var item in result)
            {
                TestContext.WriteLine(item.ToString());
                Debug.WriteLine(item.ToString());
                Console.WriteLine(item.ToString());
            }

            Assert.IsNotNull(result);
        }
    }
}
