using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    
    public class AdditionalItemOffer: OfferProducts
    {
        private IProduct _requiredItem;
        private int _discountedPrice;
        public AdditionalItemOffer(IProduct product, IProduct requierdNumberOfItems, int discountedPrice) : base(product)
        {
            _requiredItem = requierdNumberOfItems;
            _discountedPrice = discountedPrice;
        }

        public override float calculatePrice(int totalRequiredItem)
        {
            float finalPrice = 0;
            if(totalRequiredItem == 1)
            finalPrice = _discountedPrice;
            return finalPrice;
        }

        public int calculateAdditionalCost(int quantity_C, int quantity_D)
        {
            //Calculating price for extra C items or C == D quantity

            int finalPrice = 0;
            if(quantity_C == quantity_D)
            {
                finalPrice =  _discountedPrice * quantity_C;
            } else if(quantity_C > quantity_D)
            {
                int additionalItems = quantity_C - quantity_D;
                finalPrice = (productPrice * additionalItems) + (_discountedPrice * quantity_D);
            }
            return finalPrice;
        }
    }
}
