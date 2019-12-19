using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{

    [TestClass]
    public class ExistsTests
    {
        [TestMethod]
        public void ExistsTest1()
        {

            int[] ints = { -9, 14, 37, 102 };
            var num = 102;            

            Assert.IsTrue(Exists.Answer(ints, num));
        }
        [TestMethod]
        public void ExistsTest2()
        {

            int[] ints = { -9, 14, 37, 102 };
            var num = 36;

            Assert.IsFalse(Exists.Answer(ints, num));
        }        
    }
}