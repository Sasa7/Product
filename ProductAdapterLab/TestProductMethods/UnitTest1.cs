﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductLib;
using ProductAdapterLib;

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

        [TestMethod]
        public void Test_That_SomeExternalVendorProductAdapterProperties_AreNotEmpty()
        {
            //Arrange
            int expectedPricePerUnit = 1;
            string expectedDescription = "Description";
            string expectedEANCode = "4444";
            //Act
            IProduct actual = new ProductAdapterLib.SomeExternalVendorProductAdapter(new SomeExternalVendorProduct());
            //Assert
            Assert.AreEqual(expectedPricePerUnit, actual.UnitPrice);
            Assert.AreEqual(expectedDescription, actual.Title);
            Assert.AreEqual(expectedEANCode, actual.BarCode);
        }
    }
}
