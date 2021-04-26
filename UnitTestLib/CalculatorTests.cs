using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddTest()
        {
            var actual = Calculator.Add(2, 2);
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void SubtractTest()
        {
            var actual = Calculator.Subtract(4, 2);
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void MulptilyTest()
        {
            var actual = Calculator.Mulptily(4, 2);
            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        public void DivideTest()
        {
            var actual = Calculator.Divide(4, 2);
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException),
            "value exceeds")]
        public void OverflowExceptionAddTest()
        {
            var a = int.MaxValue -1;
            _ = Calculator.Add(a, a);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException),
            "value exceeds")]
        public void OverflowExceptionMultiplyTest()
        {
            const int a = 780000000;
            _ = Calculator.Mulptily(a, a);
        }
    }
}
