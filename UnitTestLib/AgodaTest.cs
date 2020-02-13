using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TaskLib;

namespace UnitTestLib
{

    [TestClass]
    public class AgodaTests
    {
        [TestMethod]
        public void ReverseTest()
        {
            var input = "agoda best apps";
            var expected = "apps best agoda";


            Assert.AreEqual(expected, Agoba.reverseWords(input));
        }
        [TestMethod]
        public void WithoutPairTest()
        {
            var input = new List<int> { 5, 23, 23, 66, 5, 23, 7, 0 };
            var expected = new List<int> { 66, 7 };


            CollectionAssert.AreEqual(expected, Agoba.getFirstTwoElementsWithoutPair(input));
        }
    }
}