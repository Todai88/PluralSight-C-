using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    public class GradeBookTests
    {
        [TestClass]
        public class MyTestClass
        {
            GradeBook book;
            GradeStatistics bookStats;

            [TestInitialize]
            public void Initialize()
            {
                this.book = new GradeBook();
                book.AddGrade(35.1f);
                book.AddGrade(90);
                this.book.Name = "Joakim's Grade Book";
                this.bookStats = this.book.ComputeStatistics();
            }

            [TestMethod]
            public void TestCorrectHighestGrade()
            {
                Assert.AreEqual(90, this.bookStats.HighestGrade);
            }

            [TestMethod]
            public void TestCorrectMinGrade()
            {
                Assert.AreEqual(35.1f, bookStats.LowestGrade);
            }

            [TestMethod]
            public void TestIncorrectMaxGrade()
            {
                Assert.AreNotEqual(80, bookStats.HighestGrade);
            }

            [TestMethod]
            public void TestIncorrectMinGrade()
            {
                Assert.AreNotEqual(30, bookStats.LowestGrade);
            } 

            [TestMethod]
            public void TestCorrectAverage()
            {
                Assert.AreEqual(62.55f, bookStats.AverageGrade, 0.01);
            }

            [TestMethod]
            public void TestIncorrectAverage()
            {
                Assert.AreNotEqual(32, bookStats.AverageGrade);
            }

            [TestMethod]
            public void TestCorrectName()
            {
                Assert.AreEqual("Joakim's Grade Book", book.Name);
            }

            [TestMethod]
            public void TestIncorrectName()
            {
                Assert.AreNotEqual("Beth's Grade Book", book.Name);
            }

            [TestCleanup]
            public void TestCleanup()
            {
                this.book = null;
                this.bookStats = null;
            }
        }


    }
}
