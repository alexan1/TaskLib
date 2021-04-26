using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class PairElementTest
    {
        [TestMethod]
        public void FindIdenticalPairs1()
        {
            int[] numbers = { 3, 5, 6, 3, 3, 5 };
            const int result = 4;

            Assert.AreEqual(result, PairElement.FindIdenticalPairs(numbers));
        }
    }
}
