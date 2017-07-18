using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiquidThinking.CLI;

namespace LiquidThinking.Tests
{
    [TestClass]
    public class ArgumentParserShould
    {
        [TestMethod]
        public void ReturnFalse_GivenCorrectOptions_WhenTestingContainsIllegalOptions()
        {
            string[] arguments = new string[]{
                "Some things",
                "-l",
                "-v",
                "-w"
            };
            var argumentParser = new ArgumentParser(arguments);
            var expected = false;
            var actual = argumentParser.ContainsIllegalOptions();

            Assert.AreEqual(expected, actual);
        }
    }
}
