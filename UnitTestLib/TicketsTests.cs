using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{

    [TestClass]
    public class TicketsTests
    {
        [TestMethod]
        public void TicketsTest1()
        {
            var a = new int[] { 1, 2, 4, 5, 7, 29, 30 };
            var expected = 11;

            Assert.AreEqual(expected, Tickets.Solution(a));
        }
    }
}