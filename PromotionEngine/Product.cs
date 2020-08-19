using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Product : IProduct
    {


        public int productPrice { get; set; }
        public string productName { get; set; }
        public string productType { get; set; }
        public List<string> discountList { get; set; }
    }
}
