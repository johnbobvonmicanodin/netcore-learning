using ClassLibrary.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository pr)
        {
            this._productRepository = pr;
        }

        public Product AddProduct(Product p)
        {
            return this._productRepository.AddProduct(p);
        }

        public Product UpdateProduct(Product p)
        {
            return this._productRepository.UpdateProduct(p);
        }

        public void DeleteProduct(Product p)
        {
            this._productRepository.DeleteProduct(p);
        }

        public List<Product> GetAllProduct()
        {
            return this._productRepository.GetAllProduct();
        }
    }
}
