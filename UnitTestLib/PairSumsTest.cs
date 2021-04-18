using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{

    [TestClass]
    public class PairSumsTest
    {
        [TestMethod]
        public void PairSumTest1()
        {
            int[] nums = {1,2,3,4,3};
            var sum = 6;
            var result = 2;

            Assert.AreEqual(result, PairSums.numberOfWays(nums, sum));
        }
        [TestMethod]
        public void PairSumTest2()
        {
            int[] nums = {1,5,3,3,3};
            var sum = 6;
            var result = 4;

            Assert.AreEqual(result, PairSums.numberOfWays(nums, sum));
        }       
    }
}