using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polygons.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Test
{
    [TestClass]
    public class OctagonTest
    {
        public Octagon octagon;  

        [TestInitialize]
        public void TestInitialize()
        {
            octagon = new Octagon(5);
        }

        [TestMethod]
        public void GivenCorrectInput_WhenTestingGetArea_Return120_71()
        {
            var expected = 120.71;
            var actual = octagon.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenCorrectInput_WhenTEstingGetPerimeter_Return40()
        {
            var expected = 40;
            var actual = octagon.GetPerimeter();

            Assert.AreEqual(expected, actual);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            octagon.Dispose();
        }
    }
}
