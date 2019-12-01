using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskLib;

namespace UnitTestLib
{

    [TestClass]
    public class SynonymsTest
    {
        [TestMethod]
        public void Sentence1()
        {
            var text = "I am happy today but was sad yesterday";
            var synonoms = new Dictionary<string, string>{ { "happy", "joy" }, { "sad", "sorrow" }, { "joy", "cheerful" } };
            

            var expected = new List<string> {"I am cheerful today but was sad yesterday",
                "I am cheerful today but was sorrow yesterday",
                "I am happy today but was sad yesterday",
                "I am happy today but was sorrow yesterday",
                "I am joy today but was sad yesterday",
                "I am joy today but was sorrow yesterday" };
            Assert.AreEqual(expected, Synonyms.Variants(text, synonims);
        }
        [TestMethod]
        public void Sentence2()
        {
            Assert.AreEqual(0, Calk.Calc("1 - 1"), 1e-15);
        }
        [TestMethod]
        public void Sentence3()
        {
            Assert.AreEqual(1, Calk.Calc("1* 1"), 1e-15);
            Assert.AreEqual(1476, Calk.Calc("12* 123"), 1e-15);
        }
    }
}