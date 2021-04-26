using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;


namespace UnitTestLib
{
    [TestClass]
    public class ObjectsTests
    {
        [TestMethod]
        public void ATest()
        {
            const string expected = "A.F";
            var a = new A();            
            var result = a.F();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BTest()
        {
            const string expected = "B.F";
            var b = new B();
            var result = b.F();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ABTest()
        {
            const string expected = "B.F";
            A b = new B();
            var result = b.F();

            Assert.AreEqual(expected, result);
        }
    }
}
