using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{


    [TestClass]
    public class PossibilitiesTest
    {
        [TestMethod]
        public void ASingleSignal()
        {
            Assert.AreEqual(new List<string> { "E" }, Morse.Possibilities("."));
            Assert.AreEqual(new List<string> { "A" }, Morse.Possibilities(".-"));
        }
        [TestMethod]
        public void AWordWithASingleUnknownSignal()
        {
            Assert.AreEqual(new List<string> { "E", "T" }, Morse.Possibilities("?"));
            Assert.AreEqual(new List<string> { "I", "N" }, Morse.Possibilities("?."));
            Assert.AreEqual(new List<string> { "I", "A" }, Morse.Possibilities(".?"));
        }
    }
}