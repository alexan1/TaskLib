using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskLib;

namespace UnitTestLib
{

    [TestClass]
    public class BalanceTest
    {
        [TestMethod]
        public void ShouldBeTrue()
        {
            var input = "()";
            Assert.IsTrue(Balance.Check(input));
        }
        [TestMethod]
        public void ShouldBeTrue1()
        {
            var input = "()[]{}";
            Assert.IsTrue(Balance.Check(input));
        }
        [TestMethod]
        public void ShouldBeFalse1()
        {

            var input = "(]";
            Assert.IsFalse(Balance.Check(input));
        }
        [TestMethod]
        public void ShouldBeFalse2()
        {
            var input = "([)]";
            Assert.IsFalse(Balance.Check(input));
        }
        [TestMethod]
        public void ShouldBeTrue2()
        {
            var input = "{[]}";
            Assert.IsTrue(Balance.Check(input));
        }
    }
}