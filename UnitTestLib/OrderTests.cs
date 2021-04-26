using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TaskLib;

namespace UnitTestLib
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void OrderTest1()
        {
            var orders = new List<Order>
            {
                new Order { Customer = "C3", Price = 125m },
                new Order { Customer = "C2", Price = 150m },
                new Order { Customer = "C1", Price = 50m },
                new Order { Customer = "C1", Price = 25m }
            };

            var expected = new List<string> { "C3", "C2" };
            
            CollectionAssert.AreEqual(expected, Order.GetSuperCustomers(orders).ToList());
        }
    }
}