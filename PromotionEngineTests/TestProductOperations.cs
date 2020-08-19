using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PromotionEngine;

namespace PromotionEngineTests
{
    [TestClass]
    public class TestProductOperations
    {
        // Test cases for ProductOperations class which will calculate total Price for given quantity of different items.
        [TestMethod]
        public void TestWithquantity1()
        {
            var consoleMock = new Mock<IConsoleMethods>();
            consoleMock.Setup(c => c.WriteLine(It.IsAny<string>()));

            ProductOperations productOperations = new ProductOperations(consoleMock.Object);
            productOperations.registerProductOffers();
            float totalCost = productOperations.calculateTotalPrice(1, 1, 1, 0);
            Assert.AreEqual(100, totalCost);
        }

        [TestMethod]
        public void TestWithquantityMoreThan1()
        {
            var consoleMock = new Mock<IConsoleMethods>();
            consoleMock.Setup(c => c.WriteLine(It.IsAny<string>()));

            ProductOperations productOperations = new ProductOperations(consoleMock.Object);
            productOperations.registerProductOffers();
            float totalCost = productOperations.calculateTotalPrice(5, 5, 1, 0);
            Assert.AreEqual(370, totalCost);
        }

        [TestMethod]
        public void TestWithquantityMoreThan1_Scenario3()
        {
            var consoleMock = new Mock<IConsoleMethods>();
            consoleMock.Setup(c => c.WriteLine(It.IsAny<string>()));

            ProductOperations productOperations = new ProductOperations(consoleMock.Object);
            productOperations.registerProductOffers();
            float totalCost = productOperations.calculateTotalPrice(3, 5, 1, 1);
            Assert.AreEqual(280, totalCost);
        }
    }
}
