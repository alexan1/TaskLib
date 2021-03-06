﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class SmallestPositiveIntegerTests
    {
        [TestMethod]
        public void SmallestPositiveInteger1()
        {
            int[] input = { 1, 3, 6, 4, 1, 2 };
            const int expected = 5;

            Assert.AreEqual(expected, SmallestPositiveInteger.Solution(input));
        }
        [TestMethod]
        public void SmallestPositiveInteger2()
        {
            int[] input = { 1, 2, 3 };
            const int expected = 4;

            Assert.AreEqual(expected, SmallestPositiveInteger.Solution(input));
        }
        [TestMethod]
        public void SmallestPositiveInteger3()
        {
            int[] input = { -1, -3 };
            const int expected = 1;

            Assert.AreEqual(expected, SmallestPositiveInteger.Solution(input));
        }
    }
}