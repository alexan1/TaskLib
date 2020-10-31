using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class PhoneNumberTest
    {
        [TestMethod]
        public void FormatPhoneNumber1()
        {
            var number = "5149623486";
            var result = "514-962-348-6";

            Assert.AreEqual(result, PhoneNumber.FormatPhoneNumber(number));
        }
    }
}
