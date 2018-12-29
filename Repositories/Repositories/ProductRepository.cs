using ClassLibrary.Models;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly KlaydSoulDbContext _context;

        public ProductRepository(KlaydSoulDbContext context)
        {
            this._context = context;
        }

        public Basket AddProduct(Product p)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product p)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProduct()
        {
            throw new NotImplementedException();
        }
    }
}
