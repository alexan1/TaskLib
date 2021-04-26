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
            var a = new[] { 1, 2, 4, 5, 7, 29, 30 };
            const int expected = 11;

            Assert.AreEqual(expected, Tickets.Solution(a));
        }
    }
}