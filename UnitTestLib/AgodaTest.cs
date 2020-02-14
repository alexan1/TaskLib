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


            Assert.AreEqual(expected, Agoba.ReverseWords(input));
        }
        [TestMethod]
        public void WithoutPairTest()
        {
            var input = new List<int> { 5, 23, 23, 66, 5, 23, 7, 0 };
            var expected = new List<int> { 66, 7 };


            CollectionAssert.AreEqual(expected, Agoba.GetFirstTwoElementsWithoutPair(input));
        }

        [TestMethod]
        public void SortDatesTest()
        {
            var input = new List<string> {"20 Oct 2052", "06 Jun 1933", "26 May 1960", "20 Sep 1958",
                "16 Mar 2068", "25 May 1912", "16 Dec 2018", "26 Dec 2061", "04 Nov 2030", "28 Jul 1963"};
            var expected = new List<string> {"25 May 1912", "06 Jun 1933", "20 Sep 1958", "26 May 1960",
                "28 Jul 1963", "16 Dec 2018", "04 Nov 2030", "20 Oct 2052", "26 Dec 2061", "16 Mar 2068"};


            CollectionAssert.AreEqual(expected, Agoba.SortDates(input));
        }
    }
}