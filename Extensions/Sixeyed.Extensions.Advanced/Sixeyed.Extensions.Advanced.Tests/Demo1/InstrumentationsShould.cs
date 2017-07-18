using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace Sixeyed.Extensions.Advanced.Tests
{
    [TestClass]
    public class InstrumentationsShould
    {
        [TestMethod]
        public void Return750_GivenSleep750_WhenTestingStart()
        {
            var instrumentation = new Instrumentation();
            instrumentation.Start();
            Thread.Sleep(750);
            Assert.AreEqual(1, instrumentation.GetElapsedTime());
        }

        [TestMethod]
        public void ReturnBetween750And751_GivenSleep750_WhenTestingGetPreciseElapsedTimeExtension()
        {
            var instrumentation = new Instrumentation();
            instrumentation.Start();
            Thread.Sleep(750);
            var elapsed = instrumentation.GetPreciseElapsedTime();
            Assert.IsTrue(elapsed >= 0.75 && elapsed <= 0.78);
        }

        [TestMethod]
        public void Return750_GivenSleep750_WhenTestingGetReallyPreciseTime()
        {
            var instrumentation = new Instrumentation();
            instrumentation.StartWithPrecision();
            Thread.Sleep(750);
            Assert.AreEqual(750, instrumentation.GetReallyPreciseElapsedTime());
        }
    }
}
