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
            var expected = "A.F";
            A a = new A();            
            var result = a.F();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BTest()
        {
            var expected = "B.F";
            B b = new B();
            var result = b.F();

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void ABTest()
        {
            var expected = "B.F";
            A b = new B();
            var result = b.F();

            Assert.AreEqual(expected, result);
        } 

    }
}
