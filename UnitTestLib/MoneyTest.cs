using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class CountChangeTest
    {
        [TestMethod]
        public void ShouldHandleTheExampleCase()
        {
            Assert.AreEqual(3, Money.CountChange(4, new int[] { 1, 2 }));
        }
        [TestMethod]
        public void ShouldHandleAnotherSimpleCase()
        {
            Assert.AreEqual(4, Money.CountChange(10, new int[] { 5, 2, 3 }));
        }
    }
}