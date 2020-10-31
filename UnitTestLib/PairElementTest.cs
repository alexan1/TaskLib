using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            var result = 4;

            Assert.AreEqual(result, PairElement.FindIdenticalPairs(numbers));
        }
    }
}
