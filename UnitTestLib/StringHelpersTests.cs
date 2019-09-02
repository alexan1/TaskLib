using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "wordNumberToFind < 1")]
        public void ArgumentOutOfRangeExceptionTest()
        { 
            var input = "one two three";
            var wordNumberToFind = 0;
            _ = StringHelpers.GetWordFromText(input, wordNumberToFind);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Not enough words")]
        public void ArgumentExceptionTest()
        {
            var input = "one";
            var wordNumberToFind = 2;
            _ = StringHelpers.GetWordFromText(input, wordNumberToFind);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "input is null")]
        public void ArgumentNullExceptionTest()
        {
            string input = null;
            var wordNumberToFind = 2;
            _ = StringHelpers.GetWordFromText(input, wordNumberToFind);
        }

    }
}
