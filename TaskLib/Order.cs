using System.Collections.Generic;
using System.Linq;

namespace TaskLib
{
    public class Order
    {
        public string Customer { get; set; }
        public decimal Price { get; set; }

        public static IEnumerable<string> GetSuperCustomers(List<Order> orders)
        {
            return orders.Where(x => x.Price > 100).Select(x => x.Customer);
        }

    }

    
}
