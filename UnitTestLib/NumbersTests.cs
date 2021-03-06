﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class NumbersTests
    {
        [TestMethod]
        public void Is1000Numbers()
        {
            const int expected = 1000;
            var result = Numbers.Get1000Primes();

            Assert.AreEqual(expected, result.Count());
        }

        [TestMethod]
        public void ThisIsPrime()
        {
            const int prime = 3;
            Assert.IsTrue(Numbers.IsPrime(prime));
        }

        [TestMethod]
        public void ThisIsNotPrime()
        {
            const int notprime = 4;
            Assert.IsFalse(Numbers.IsPrime(notprime));
        }

        [TestMethod]
        public void RandomIsPrime()
        {
            var result = Numbers.Get1000Primes();
            var rand = new Random();
            var enumerable = result as int[] ?? result.ToArray();
            var index = rand.Next(2, enumerable.Count());
            var num =  enumerable.ElementAt(index);

            Assert.IsTrue(Numbers.IsPrime(num));
        }

        [TestMethod]
        public void GenerateLowestNumberTest1()
        {
            Assert.AreEqual("012", Numbers.GenerateLowestNumber("4205123", 4));
        }

        [TestMethod]
        public void GenerateLowestNumberTest2()
        {
            Assert.AreEqual("104", Numbers.GenerateLowestNumber("216504", 3));
        }
    }
}
