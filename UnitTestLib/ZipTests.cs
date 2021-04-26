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
            const int b = 12;
            const int a = 56;
            const int expected = 5162;

            Assert.AreEqual(expected, Zip.Solution(a, b));
        }
        [TestMethod]
        public void ZipTest3()
        {
            const int a = 12345;
            const int b = 678;
            const int expected = 16273845;

            Assert.AreEqual(expected, Zip.Solution(a, b));
        }

        [TestMethod]
        public void ZipTest4()
        {
            const int a = 123;
            const int b = 67890;
            const int expected = 16273890;

            Assert.AreEqual(expected, Zip.Solution(a, b));
        }

        [TestMethod]
        public void ZipTest5()
        {
            const int a = 1234;
            const int b = 0;
            const int expected = 10234;

            Assert.AreEqual(expected, Zip.Solution(a, b));
        }
    }
}