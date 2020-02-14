using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class MobiTest
    {
        [TestMethod]
        public void MostCommonWordTest()
        {
            var words = "two one three one three one";
            var expected = "one";
            Assert.AreEqual(expected, Mobi.MostCommonWord(words));
        }
    }
}
