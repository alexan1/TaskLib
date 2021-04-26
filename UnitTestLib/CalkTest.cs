using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void ShouldHandleAddition1()
        {
            Assert.AreEqual(2, Calk.Calc("1+1"), 1e-15);
        }
        [TestMethod]
        public void ShouldHandleAddition2()
        {
            Assert.AreEqual(15, Calk.Calc("10+5"), 1e-15);
        }
        [TestMethod]
        public void ShouldHandleSubtraction1()
        {
            Assert.AreEqual(0, Calk.Calc("1-1"), 1e-15);
        }
        [TestMethod]
        public void ShouldHandleSubtraction2()
        {
            Assert.AreEqual(10, Calk.Calc("11-1"), 1e-15);
        }
        [TestMethod]
        public void ShouldHandleMultiplication1()
        {
            Assert.AreEqual(1, Calk.Calc("1*1"), 1e-15);
        }
        [TestMethod]
        public void ShouldHandleMultiplication2()
        {
            Assert.AreEqual(15, Calk.Calc("5*3"), 1e-15);
        }
        [TestMethod]
        public void ShouldHandleMultiplication3()
        {
            Assert.AreEqual(1476, Calk.Calc("12* 123"), 1e-15);
        }
    }
}