using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class PhoneNumberTest
    {
        [TestMethod]
        public void FormatPhoneNumber1()
        {
            const string number = "5149623486";
            const string result = "514-962-348-6";

            Assert.AreEqual(result, PhoneNumber.FormatPhoneNumber(number));
        }
    }
}
