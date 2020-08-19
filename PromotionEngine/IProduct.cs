using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public interface IProduct
    {
         string productName { get; set; }
         string productType { get; set; }

         int productPrice { get; set; }
        List<string> discountList { get; set; }
    }
}
