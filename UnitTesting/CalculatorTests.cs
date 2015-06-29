using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTesting
{
    [TestClass]
    public class CalculatorTests
    {
        Calculator cal = new Calculator();

        [TestMethod]
        public void SimpleAdd()
        {            
            int results = cal.Add(2, 2);
            Assert.AreEqual(4, results);
        }

        [TestMethod]
        public void SimpleSubtract()
        {            
            int results = cal.Subtract(2, 2);
            Assert.AreEqual(0, results);
        }

        [TestMethod]
        public void SimpleMultiplication()
        {
            int results = cal.Multiply(2, 2);
            Assert.AreEqual(4, results);
        }

        [TestMethod]
        public void SimpleDivision()
        {
            int results = cal.Divide(2, 2);
            Assert.AreEqual(1, results);
        }
    }
}
