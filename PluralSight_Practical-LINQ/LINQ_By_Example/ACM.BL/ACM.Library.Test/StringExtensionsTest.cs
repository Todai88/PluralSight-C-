using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Library.Test
{
    [TestClass]
    public class StringExtensionsTest
    {
        public TestContext TestContext { get; set; }
        public string Result { get; set; }
        public string Source { get; set; }
        public string Expected { get; set; }
        [TestInitialize]
        public void TestInitialize()
        {
            this.Source = "the return of the king";
            this.Expected = "The Return Of The King";
            this.Result = Source.ConvertToTitlecase();
        }


        [TestMethod]
        public void TestStringNotEmptyAfterConversion()
        {
            Assert.IsNotNull(this.Result);
        }

        [TestMethod]
        public void TestConvertToTitleCase()
        {
            Assert.AreEqual(this.Expected, this.Result);
        }


        [TestCleanup]
        public void TestCleanup()
        {
            this.TestContext = null;
            this.Result = null;
            this.Source = null;
            this.Expected = null;
        }
    }
}
