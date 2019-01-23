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
    }
}
