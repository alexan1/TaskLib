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

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "input is null")]
        public void ArgumentNullExceptionReverseTest()
        {
            string input = null;
            
            _ = StringHelpers.Reverse(input);
        }

        [TestMethod]
        public void CorrectStringTest1()
        {
            var input = "123";

            var expected = "";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest2()
        {
            var input = "";

            var expected = "";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest3()
        {
            var input = "a";

            var expected = "Z";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest4()
        {
            var input = "abfplBC";

            var expected = "ZYfplYX";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest5()
        {
            var input = "ABC";

            var expected = "ZYX";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest6()
        {
            var input = "abc";

            var expected = "ZYX";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest7()
        {
            var input = "DEF";

            var expected = "DEF";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest8()
        {
            var input = "a";

            var expected = "Z";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectStringTest9()
        {
            var input = "qw123erty";

            var expected = "qwerty";
            var actual = StringHelpers.Correct(input);

            Assert.AreEqual(expected, actual);
        }


    }
}
