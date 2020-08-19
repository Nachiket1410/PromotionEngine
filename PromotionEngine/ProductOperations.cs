using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class ProductOperations :IConsoleMethods
    {
        Product productA;
        ComboOffer productA_Combo;
        PercentDiscountOffer productA_PercentDiscount;
        Product productB;
        ComboOffer productB_Combo;
        Product productC;
        AdditionalItemOffer productC_AdditionItem;
        Product productD;       
        NoOffer productD_NoOffer;

        public IConsoleMethods console;
        public ProductOperations(IConsoleMethods consoleMethods) { this.console = consoleMethods; }

        public ProductOperations() { }
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
        public void registerProductOffers()
        {
            productA = new Product();
            productA.productName = "A";
            productA.productPrice = 50;
            productA.productType = "clothing";
            productA.discountList = new List<string>();

            productA_Combo = new ComboOffer(productA, 3, 130);
            productA.discountList.Add("Combo");

            productA_PercentDiscount = new PercentDiscountOffer(productA, 10, 50);
            productA.discountList.Add("PercentDiscount");
            
            productB = new Product();
            productB.productName = "B";
            productB.productPrice = 30;
            productB.productType = "TV";
            productB.discountList = new List<string>();
            productB_Combo = new ComboOffer(productB, 2, 45);
            productB.discountList.Add("Combo");
            productD = new Product();
            productD.productName = "D";
            productD.productPrice = 15;
            productD.productType = "Mobile";
            productD.discountList = new List<string>();
            productD_NoOffer = new NoOffer(productD);
            productC = new Product();
            productC.productName = "D";
            productC.productPrice = 20;
            productC.productType = "Mobile";

            productC.discountList = new List<string>();
            productC_AdditionItem = new AdditionalItemOffer(productC, productD, 30);
            productC.discountList.Add("AdditionalItem");
            
            
        }

        public float calculateTotalPrice(int quantity_A, int quantity_B, int quantity_C, int quantity_D)
        {
            float totalPrice;
            float productA_cost = 0;
            float productB_cost = 0;
            float productC_cost = 0;
            float productD_cost = 0;
            float productA_comboDiscountedPrice = 0;
            float productA_percentDiscountedPrice = 0;

            // Considering Product A has both discount of combo and percent discount. So giving user discount which gives him/her max savings
            foreach (string discount in productA.discountList)
            {
                if (discount.Equals("Combo"))
                {
                    productA_comboDiscountedPrice = productA_Combo.calculatePrice(quantity_A);

                }
                else if (discount.Equals("PercentDiscount"))
                {
                    productA_percentDiscountedPrice = productA_PercentDiscount.calculatePrice(quantity_A);

                }

            }
            productA_cost = productA_comboDiscountedPrice < productA_percentDiscountedPrice ? productA_comboDiscountedPrice : productA_percentDiscountedPrice;
            Console.WriteLine("\n\n Product A total cost :" + productA_cost);

            // Calculating Product B price
            productB_cost = productB_Combo.calculatePrice(quantity_B);
            Console.WriteLine("\n\n Product B total cost :" + productB_cost);

            // Calculating product C price based on multiple possible combinations of quantity of C and D
            if (quantity_C == 1 && quantity_D == 1)
            {
                productC_cost = productC_AdditionItem.calculatePrice(1);
            }
            else
            {
                productC_cost = productC_AdditionItem.calculateAdditionalCost(quantity_C, quantity_D);
            }
            Console.WriteLine("\n\n Product C total cost :" + productC_cost);

            // For extra items of Product D this is the logic
            if (quantity_D > quantity_C)
            {
                int extra_DItems = quantity_D - quantity_C;
                productD_cost = productD_NoOffer.calculatePrice(extra_DItems);
            }
            Console.WriteLine("\n\n Product D total cost :" + productD_cost);
            return totalPrice = productA_cost + productB_cost + productC_cost + productD_cost;
        }
    }

}



