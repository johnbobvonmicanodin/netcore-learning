using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repositories.Interfaces;
using Repositories.Repositories;
using Services.Services;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Tests.Services
{
    [TestClass]
    public class ProductServiceTester
    {
        private IProductRepository _productRepository;
        private IProductService _productService;

        public ProductServiceTester()
        {
            _productRepository = new ProductRepository(null);
            _productService = new ProductService(_productRepository);
        }

        [TestMethod]
        public void AddProductWithNegativePrice()
        {
            var mock = new Mock<IProductRepository>();
            var newProd = new Product() { PriceHT = -1 };

            var service = new ProductService(mock.Object);
            var repProd = service.AddProduct(newProd);

            Assert.IsTrue(repProd.PriceHT == 1);
        }

        [TestMethod]
        public void AddProductWithNegativeTaxes()
        {
            var mock = new Mock<IProductRepository>();
            var newProd = new Product() { TVA = -1 };

            var service = new ProductService(mock.Object);
            var repProd = service.AddProduct(newProd);

            Assert.IsTrue(repProd.TVA == 0);
        }
    }
}
