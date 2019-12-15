using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{

    [TestClass]
    public class ZipTests
    {
        [TestMethod]
        public void ZipTest1()
        {

            var a = 12;
            var b = 56;
            var expected = 1526;

            Assert.AreEqual(expected, Zip.Solution(a, b));
        }
        [TestMethod]
        public void ZipTest2()
        {
            var b = 12;
            var a = 56;
            var expected = 5162;

            Assert.AreEqual(expected, Zip.Solution(a, b));
        }
        [TestMethod]
        public void ZipTest3()
        {
            var a = 12345;
            var b = 678;
            var expected = 16273845;

            Assert.AreEqual(expected, Zip.Solution(a, b));
        }

        [TestMethod]
        public void ZipTest4()
        {
            var a = 123;
            var b = 67890;
            var expected = 16273890;

            Assert.AreEqual(expected, Zip.Solution(a, b));
        }

        [TestMethod]
        public void ZipTest5()
        {
            var a = 1234;
            var b = 0;
            var expected = 10234;

            Assert.AreEqual(expected, Zip.Solution(a, b));
        }
    }
}