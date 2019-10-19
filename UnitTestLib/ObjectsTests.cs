using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;
using System.Diagnostics;
using System.Reflection;


namespace UnitTestLib
{
    [TestClass]
    public class ObjectsTests
    {
        [TestMethod]
        public void ATest()
        {
            //var st = new StackTrace();
            //var sf = st.GetFrame(1);

            //var currentMethodName = sf.GetMethod().Name;

            //var res = MethodBase.GetCurrentMethod().Name;


            var expected = "A.F";
            A a = new A();
            //var name = type
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
