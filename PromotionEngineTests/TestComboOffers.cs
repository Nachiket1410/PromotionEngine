using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineTests
{
    [TestClass]
    public class TestComboOffers
    {
        // Test cases for Combo Offers. Similarly we can write test cases for other product offers. 
        // Due to time limitations not adding other test cases.
        [TestMethod]
        public void TestComboOfferCalculation()
        {
            Product productA = new Product();
            productA.productName = "A";
            productA.productPrice = 50;
            productA.productType = "clothing";
            productA.discountList = new List<string>();

            ComboOffer productA_Combo = new ComboOffer(productA, 3, 130);
            float Price = productA_Combo.calculatePrice(3);
            Assert.AreEqual(130, Price);
        }

        [TestMethod]
        public void TestComboOfferCalculation_extraItems()
        {
            Product productA = new Product();
            productA.productName = "A";
            productA.productPrice = 50;
            productA.productType = "clothing";
            productA.discountList = new List<string>();

            ComboOffer productA_Combo = new ComboOffer(productA, 3, 130);
            float Price = productA_Combo.calculatePrice(5);
            Assert.AreEqual(230, Price);
        }

    }
}
