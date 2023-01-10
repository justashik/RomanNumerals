using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsApp;
using System;

namespace RomanNumeralsUnitTesting
{
    [TestClass]
    public class RandomValues
    {
        [TestMethod]
        public void RandomNumbers1999()
        {
            var result = Processes.ConvertToNumerals("1999");
            Assert.AreEqual("MCMXCIX", result);
        }

        [TestMethod]
        public void RandomNumbers232()
        {
            var result = Processes.ConvertToNumerals("232");
            Assert.AreEqual("CCXXXII", result);
        }

        [TestMethod]
        public void RandomNumbers1()
        {
            var result = Processes.ConvertToNumerals("654");
            Assert.AreEqual("DCLIV", result);
        }


    }
}
