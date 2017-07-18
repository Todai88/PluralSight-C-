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
    public class TriangleTests
    {
        public Triangle triangle { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            triangle = new Triangle(5);
        }

        [TestMethod]
        public void GivenCorrectInput_WhenTestingGePerimeter()
        {
            var expected = 15;
            var actual = triangle.GetPerimeter();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenCorrectInput_WhenTestingGetArea_Return10_83()
        {
            var expected = 10.83;
            var actual = triangle.GetArea();

            Assert.AreEqual(expected, actual, 0.01);

        }
        [TestCleanup]
        public void TestCleanup()
        {

        }
    }
}
