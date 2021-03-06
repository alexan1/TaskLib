﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class FacebookTest
    {
        [TestMethod]
        public void PairSumTest1()
        {
            int[] nums = {1,2,3,4,3};
            const int sum = 6;
            const int result = 2;

            Assert.AreEqual(result, Facebook.NumberOfWays(nums, sum));
        }
        [TestMethod]
        public void PairSumTest2()
        {
            int[] nums = {1,5,3,3,3};
            const int sum = 6;
            const int result = 4;

            Assert.AreEqual(result, Facebook.NumberOfWays(nums, sum));
        }

        [TestMethod]
        public void CipherTest1()
        {
            const string input = "Zebra-493?";
            const int rotationFactor = 3;
            const string output = "Cheud-726?";

            Assert.AreEqual(output, Facebook.RotationalCipher(input, rotationFactor));
        }
        [TestMethod]
        public void CipherTest2()
        {
            const string input = "abcdefghijklmNOPQRSTUVWXYZ0123456789";
            const int rotationFactor = 39;
            const string output = "nopqrstuvwxyzABCDEFGHIJKLM9012345678";

            Assert.AreEqual(output, Facebook.RotationalCipher(input, rotationFactor));
        }

        [TestMethod]
        public void CountSubarrays1()
        {
            int[] arr = { 3, 4, 1, 6, 2 };
            int[] output = { 1, 3, 1, 5, 1 };

            CollectionAssert.AreEqual(output, Facebook.CountSubarrays(arr));           
        }
    }
}