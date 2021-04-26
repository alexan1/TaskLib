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
            CollectionAssert.AreEqual(new List<string> { "E" }, Morse.Possibilities("."));
            CollectionAssert.AreEqual(new List<string> { "A" }, Morse.Possibilities(".-"));
        }
        [TestMethod]
        public void AWordWithASingleUnknownSignal()
        {
            CollectionAssert.AreEqual(new List<string> { "E", "T" }, Morse.Possibilities("?"));
            CollectionAssert.AreEqual(new List<string> { "I", "N" }, Morse.Possibilities("?."));
            CollectionAssert.AreEqual(new List<string> { "I", "A" }, Morse.Possibilities(".?"));
        }
    }
}