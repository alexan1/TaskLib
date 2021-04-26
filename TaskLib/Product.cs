using System.Linq;

namespace TaskLib
{
    public class Product
    {
        private static int GetPriority(string productCode)
        {
            return 1;
        }

        public string[] OrderProductsByPriority(string[] productCodes)
        {
            return  productCodes.OrderBy(GetPriority).ToArray();
        }        
    }
}
