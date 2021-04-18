using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{

    [TestClass]
    public class RotationalCipherTest
    {
        [TestMethod]
        public void CipherTest1()
        {
            var input = "Zebra-493?";
            var rotationFactor = 3;
            var output = "Cheud-726?";

            Assert.AreEqual(output, RotationalCipher.rotationalCipher(input, rotationFactor));
        }
        [TestMethod]
        public void CipherTest2()
        {
            var input = "abcdefghijklmNOPQRSTUVWXYZ0123456789";
            var rotationFactor = 39;
            var output = "nopqrstuvwxyzABCDEFGHIJKLM9012345678";

            Assert.AreEqual(output, RotationalCipher.rotationalCipher(input, rotationFactor));
        }       
    }
}