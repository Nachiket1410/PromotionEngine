using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class ComboOffer: OfferProducts
    {
        private int _requiredNumberOfItems;
        private int _discountedPrice;
        public ComboOffer(IProduct product,int requierdNumberOfItems,int discountedPrice):base(product)
        {            
            _requiredNumberOfItems = requierdNumberOfItems;
            _discountedPrice = discountedPrice;
        }

        public override float calculatePrice(int totalItems)
        {
            int totalEligibleItems = totalItems / _requiredNumberOfItems;
            int remainingItems = totalItems % _requiredNumberOfItems;
            float finalPrice = _discountedPrice * totalEligibleItems + base.productPrice * remainingItems;
            return finalPrice;
        }
        
                   
    
    }
}
