using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PercentDiscountOffer: OfferProducts
    {
        private int _totalPercentDiscount;
        private int _maxDiscount;
        public PercentDiscountOffer(IProduct product, int totalPercentDiscount, int maxDiscount) : base(product)
        {
            _totalPercentDiscount = totalPercentDiscount;
            _maxDiscount = maxDiscount;
        }

        // Calculating price by giving n% of pre decided discount
        public override float calculatePrice(int totalItems)
        {
            float totalDiscount = ((totalItems * productPrice) / 100) * _totalPercentDiscount;
            float finalPrice = (totalItems * productPrice) - totalDiscount;
            return finalPrice;
        }
    }
}
