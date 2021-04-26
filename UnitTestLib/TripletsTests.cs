using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class TripletsTest
    {
        [TestMethod]
        public void TripletsTest1()
        {
            int[] input = { -1, 0, 1, 2, -1, -4 };
            //var expected = new List() { 
            //    new List<int>(){ -1, -1, 2 }, 
            //    new List<int>{ -1, 0, 1 } };

            Assert.AreEqual(18, Sum.MaxSumDivThree(input));
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