using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            int productA_quantity, productB_quantity, productC_quantity, productD_quantity;

            /// Registering product offers statically. We can add additional offers at run time also ( Please refer product A for multiple product offers
            /// but for time being registering it at compile time
            ProductOperations productOperations = new ProductOperations();
            productOperations.registerProductOffers();

            // Reading user Input for quantity of each item
            Console.WriteLine("Enter Quantity of Product A");
            string quantity_A = Console.ReadLine();
            int.TryParse(quantity_A, out productA_quantity);

            Console.WriteLine("Enter Quantity of Product B");
            string quantity_B = Console.ReadLine();
            int.TryParse(quantity_B, out productB_quantity);
            Console.WriteLine("Enter Quantity of Product C");
            string quantity_C = Console.ReadLine();
            int.TryParse(quantity_C, out productC_quantity);
            Console.WriteLine("Enter Quantity of Product D");
            string quantity_D = Console.ReadLine();
            int.TryParse(quantity_D, out productD_quantity);

            // Calculating final bill amount by sending quantity of each item
            float? totalPrice = productOperations.calculateTotalPrice(productA_quantity, productB_quantity, productC_quantity, productD_quantity);
            Console.WriteLine("\n\nTotal Price is : " + totalPrice);
            Console.ReadLine();

        }
    }
}
