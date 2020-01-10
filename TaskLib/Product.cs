using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskLib
{
    public class Product
    {
        private int GetPriority(string productCode)
        {
            return 1;
        }

        public string[] OrderProductsByPriority(string[] productCodes)
        {
            return  productCodes.OrderBy(x => GetPriority(x)).ToArray<string>();
        }

        public static string GenerateLowestNumber(string number, int n)
        {

        }
    }
}
