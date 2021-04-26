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
            const string input = "one two three";
            const int wordNumberToFind = 2;
            const string expeted = "two";

            var actual = StringHelpers.GetWordFromText(input, wordNumberToFind);

            Assert.AreEqual(expeted, actual);
        }

        [TestMethod]
        public void WordIsFound2()
        {
            const string input = "one;two three";
            const int wordNumberToFind = 2;
            const string expeted = "three";

            var actual = StringHelpers.GetWordFromText(input, wordNumberToFind);

            Assert.AreEqual(expeted, actual);
        }

        [TestMethod]
        public void ReverseTest1()
        {
            const string input = "one";
            const string expected = "eno";
            var actual = StringHelpers.Reverse(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseTest2()
        {
            const string input = "abcd dcba";
            const string expected = "abcd dcba";
            var actual = StringHelpers.Reverse(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseEmptyString()
        {
            var input = string.Empty;
            var expected = string.Empty;
            var actual = StringHelpers.Reverse(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "wordNumberToFind < 1")]
        public void ArgumentOutOfRangeExceptionTest()
        { 
            const string input = "one two three";
            const int wordNumberToFind = 0;
            _ = StringHelpers.GetWordFromText(input, wordNumberToFind);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Not enough words")]
        public void ArgumentExceptionTest()
        {
            const string input = "one";
            const int wordNumberToFind = 2;
            _ = StringHelpers.GetWordFromText(input, wordNumberToFind);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "input is null")]
        public void ArgumentNullExceptionTest()
        {
            const int wordNumberToFind = 2;
            _ = StringHelpers.GetWordFromText(null, wordNumberToFind);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "input is null")]
        public void ArgumentNullExceptionReverseTest()
        {
            _ = StringHelpers.Reverse(null);
        }

        [TestMethod]
        public void CorrectStringTest1()
        {
            const string input = "123";

            const string expected = "";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest2()
        {
            const string input = "";

            const string expected = "";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest3()
        {
            const string input = "a";

            const string expected = "Z";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest4()
        {
            const string input = "abfplBC";

            const string expected = "ZYfplYX";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest5()
        {
            const string input = "ABC";

            const string expected = "ZYX";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest6()
        {
            const string input = "abc";

            const string expected = "ZYX";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest7()
        {
            const string input = "DEF";

            const string expected = "DEF";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest8()
        {
            const string input = "a";

            const string expected = "Z";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest9()
        {
            const string input = "qw123erty";

            const string expected = "qwerty";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
