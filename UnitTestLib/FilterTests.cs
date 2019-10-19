using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;
using System.Diagnostics;
using System.Reflection;


namespace UnitTestLib
{
    [TestClass]
    public class FilterTests
    {
        [TestMethod]
        public void IsSetContain()
        {
            var filter = new Filter();
            var number = 5;
            filter.Filtrate(number); 
            Assert.IsTrue(filter.Set.Contains(number));
        }

        [TestMethod]
        public void IsNotSetContain()
        {
            var filter = new Filter();
            var number = 5;
            var number2 = 7;
            filter.Filtrate(number);
            Assert.IsFalse(filter.Set.Contains(number2));
        }

        [TestMethod]
        public void FilterCopy()
        {
            var filter1 = new Filter();
            var number = 5;            
            filter1.Filtrate(number);

            var filter2 = (Filter)filter1.CopyFilter<Filter>();

            var number2 = 7;
            filter2.Filtrate(number2);

            Assert.IsTrue(filter2.Set.Contains(number2));
            Assert.IsFalse(filter1.Set.Contains(number2));
        }


    }
}
