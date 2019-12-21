using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TaskLib;

namespace UnitTestLib
{

    [TestClass]
    public class Filter1Tests
    {
        [TestMethod]
        public void Filter1Test1()
        {
            var strings = new List<string>
            {
                "Gurt",
                "Lobster",
                "Litch",
                "Doe"
            };
            var filteredStrings = Filter1.Filter(strings).ToList();

            var expected = new List<string> { "Litch", "Lobster" };

            CollectionAssert.AreEqual(expected, filteredStrings);
        }
    }
}