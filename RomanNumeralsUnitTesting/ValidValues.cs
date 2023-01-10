using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsApp;
using System;

namespace RomanNumeralsUnitTesting
{
    [TestClass]
    public class ValidValues
    {
        [TestMethod]
        public void TestToRoman1()
        {
            var result = Processes.GetNumerals(1);
            Assert.AreEqual("I", result);
        }
        [TestMethod]
        public void TestToRoman4()
        {
            var result = Processes.GetNumerals(4);
            Assert.AreEqual("IV", result);
        }

        [TestMethod]
        public void TestToRoman5()
        {
            var result = Processes.GetNumerals(5);
            Assert.AreEqual("V", result);
        }

        [TestMethod]
        public void TestToRoman9()
        {
            var result = Processes.GetNumerals(9);
            Assert.AreEqual("IX", result);
        }

        [TestMethod]
        public void TestToRoman10()
        {
            var result = Processes.GetNumerals(10);
            Assert.AreEqual("X", result);
        }

        [TestMethod]
        public void TestToRoman40()
        {
            var result = Processes.GetNumerals(40);
            Assert.AreEqual("XL", result);
        }

        [TestMethod]
        public void TestToRoman50()
        {
            var result = Processes.GetNumerals(50);
            Assert.AreEqual("L", result);
        }

        [TestMethod]
        public void TestToRoman90()
        {
            var result = Processes.GetNumerals(90);
            Assert.AreEqual("XC", result);
        }

        [TestMethod]
        public void TestToRoman1000()
        {
            var result = Processes.GetNumerals(1000);
            Assert.AreEqual("M", result);
        }
    }
}
