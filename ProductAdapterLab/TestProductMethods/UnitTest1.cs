using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductLib;

namespace TestProductMethods
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_That_ProductProperties_AreNotEmpty()
        {
            //Arrange
            string expectedTitle = "Boll";
            decimal expectedUnitPrice = 20;
            string expectedBarCode = "55555";
            //Act
            Product product = new Product();
            //Assert
            Assert.AreEqual(expectedTitle, product.Title);
            Assert.AreEqual(expectedUnitPrice, product.UnitPrice);
            Assert.AreEqual(expectedBarCode, product.BarCode);

        }
    }
}
