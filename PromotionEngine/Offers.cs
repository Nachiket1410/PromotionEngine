using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public abstract class OfferProducts
    {
        private readonly IProduct _product;

        protected OfferProducts(IProduct product)
        {
            this._product = product;
        }

        public string productName
        {
            get { return _product.productName; }
        }

        public string productType
        {
            get { return _product.productType; }
        }
        public int productPrice
        {
            get { return _product.productPrice; }
        }

        public List<string> discountList
        {
            get { return _product.discountList; }
        }
        public abstract float calculatePrice(int totalItems);
        
    }
}
