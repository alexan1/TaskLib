using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddResr()
        {
            var actual = Calculator.Add(2, 2);
            Assert.AreEqual(4, actual);
        }

    }
}
