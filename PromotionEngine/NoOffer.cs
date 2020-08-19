using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class NoOffer : OfferProducts
    {

        public NoOffer(IProduct product) : base(product)
        {

        }
        public override float calculatePrice(int totalItems)
        {

            float finalPrice = productPrice * totalItems;
            return finalPrice;
        }
    }
}
