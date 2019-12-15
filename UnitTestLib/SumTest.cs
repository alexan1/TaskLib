using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{

    [TestClass]
    public class SumTest
    {
        [TestMethod]
        public void SumTest1()
        {
            int[] nums = { 3, 6, 5, 1, 8 };

            Assert.AreEqual(18, Sum.MaxSumDivThree(nums));
        }
        [TestMethod]
        public void SumTest2()
        {
            int[] nums = {4};

            Assert.AreEqual(0, Sum.MaxSumDivThree(nums));
        }
        [TestMethod]
        public void SumTest3()
        {
            int[] nums = { 1, 2, 3, 4, 4 };

            Assert.AreEqual(12, Sum.MaxSumDivThree(nums));
        }
    }
}