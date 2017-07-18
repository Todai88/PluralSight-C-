using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polygons.Library;

namespace Polygons.Test
{
    [TestClass]
    public class SquareTests
    {
        public Square square { get; set; }
        [TestInitialize]
        public void TestInitialize()
        {
            square = new Square(5);
        }

        [TestMethod]
        public void GivenCorrectValues_WhenTestingGetArea_Return25()
        {
            var actual = square.GetArea();
            var expected = 25;
            Assert.AreEqual(expected, actual);
        }
         
        [TestMethod]
        public void GivenCorrectValues_WhenTestingGetPerimeter_Return20()
        {
            var actual = square.GetPerimeter();
            var expected = 20;
            Assert.AreEqual(expected, actual);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            square.Dispose();
        }
    }
}
