using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class StringHelpersTests
    {
        [TestMethod]
        public void WordIsFound()
        {
            var input = "one;two three";
            var wordNumberToFind = 2;
            var expeted = "two";

            var actual = StringHelpers.GetWordFromText(input, wordNumberToFind);

            Assert.AreEqual(expeted, actual);


        }
    }
}
