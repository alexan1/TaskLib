using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class BalanceTest
    {
        [TestMethod]
        public void ShouldBeTrue()
        {
            const string input = "()";
            Assert.IsTrue(Balance.Check(input));
        }
        [TestMethod]
        public void ShouldBeTrue1()
        {
            const string input = "()[]{}";
            Assert.IsTrue(Balance.Check(input));
        }
        [TestMethod]
        public void ShouldBeFalse1()
        {
            const string input = "(]";
            Assert.IsFalse(Balance.Check(input));
        }
        [TestMethod]
        public void ShouldBeFalse2()
        {
            const string input = "([)]";
            Assert.IsFalse(Balance.Check(input));
        }
        [TestMethod]
        public void ShouldBeTrue2()
        {
            const string input = "{[]}";
            Assert.IsTrue(Balance.Check(input));
        }
    }
}