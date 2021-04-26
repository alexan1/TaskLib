using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class MobiTest
    {
        [TestMethod]
        public void MostCommonWordTest()
        {
            const string words = "two one three one three one";
            const string expected = "one";
            Assert.AreEqual(expected, Mobi.MostCommonWord(words));
        }
    }
}
