using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsApp;
using System;

namespace RomanNumeralsUnitTesting
{
    [TestClass]
    public class InvalidValues
    {
        [TestMethod]
        public void OutOfRange2001()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Processes.ConvertToNumerals("2001"));
        }

        [TestMethod]
        public void OutOfRange3242343()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Processes.ConvertToNumerals("3242343"));
        }

        [TestMethod]
        public void OutOfRange766545()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Processes.ConvertToNumerals("766545"));
        }

        [TestMethod]
        public void Text()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Processes.ConvertToNumerals("Random val"));
        }
        
        [TestMethod]
        public void NoValue()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Processes.ConvertToNumerals(""));
        }
        
        [TestMethod]
        public void DecimalValue()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Processes.ConvertToNumerals("12.3"));
        }
        
        [TestMethod]
        public void NegativeValue()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Processes.ConvertToNumerals("-20"));
        }

    }
}
