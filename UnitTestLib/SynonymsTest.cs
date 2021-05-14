using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TaskLib;

namespace UnitTestLib
{

    [TestClass]
    public class WordsTest
    {
        [TestMethod]
        public void SynonymsTest1()
        {
            const string text = "I am happy today but was sad yesterday";
            var synonims = new Dictionary<string, string>{ { "happy", "joy" }, { "sad", "sorrow" }, { "joy", "cheerful" } };
            

            var expected = new List<string> {"I am cheerful today but was sad yesterday",
                "I am cheerful today but was sorrow yesterday",
                "I am happy today but was sad yesterday",
                "I am happy today but was sorrow yesterday",
                "I am joy today but was sad yesterday",
                "I am joy today but was sorrow yesterday" };
            CollectionAssert.AreEqual(expected, Words.Synonyms(text, synonims));
        }
        [TestMethod]
        public void AnagramFalse()
        {
           Assert.IsFalse(Words.IsAnagram("Hello", "world"));
        }
        [TestMethod]
        public void AnagramTrue1()
        {
            Assert.IsTrue(Words.IsAnagram("acb", "bca"));
        }
        [TestMethod]
        public void AnagramTrue2()
        {
            Assert.IsTrue(Words.IsAnagram("Lookout", "Outlook"));
        }
    }
}