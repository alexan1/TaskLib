using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class StringHelpersTests
    {
        [TestMethod]
        public void WordIsFound1()
        {
            var input = "one two three";
            var wordNumberToFind = 2;
            var expeted = "two";

            var actual = StringHelpers.GetWordFromText(input, wordNumberToFind);

            Assert.AreEqual(expeted, actual);
        }

        [TestMethod]
        public void WordIsFound2()
        {
            var input = "one;two three";
            var wordNumberToFind = 2;
            var expeted = "three";

            var actual = StringHelpers.GetWordFromText(input, wordNumberToFind);

            Assert.AreEqual(expeted, actual);
        }

        [TestMethod]
        public void ReverseTest1()
        {
            var input = "one";
            var expected = "eno";
            var actual = StringHelpers.Reverse(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseTest2()
        {
            var input = "abcd dcba";
            var expected = "abcd dcba";
            var actual = StringHelpers.Reverse(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArgumentOutOfRangeExceptionTest()
        {
            var input = "abcd dcba";
            var expected = "abcd dcba";
            var actual = StringHelpers.Reverse(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
