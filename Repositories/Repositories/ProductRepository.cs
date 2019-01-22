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

        public Product AddProduct(Product p)
        {
            this._context.Attach(p);
            this._context.SaveChanges();

            return p;
        }

        public Product UpdateProduct(Product p)
        {
            this._context.Products.Update(p);
            this._context.SaveChanges();

            return p;
        }

        public bool DeleteProduct(Product p)
        {
            if (this._context.Products.FirstOrDefault(i => i.Id == p.Id) != null)
            {
                this._context.Users.Remove(this._context.Users.FirstOrDefault(i => i.Id == p.Id));
                this._context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Product> GetAllProduct()
        {
            return this._context.Products.ToList();
        }

        public List<Product> GetAllProductUp()
        {
            return this._context.Products.Where(p => p.Up == 1).ToList();
        }

        public List<Product> GetAllProductForward()
        {
            return this._context.Products.Where(p => p.Up == 1 && p.Forward == 1).ToList();
        }

        public Product SetProductUp(Product p)
        {
            this._context.Attach(p);
            this._context.Entry(p).Property(x => x.Up).IsModified = true;
            this._context.SaveChanges();

            return p;
        }

        public Product SetProductForward(Product p)
        {
            this._context.Attach(p);
            this._context.Entry(p).Property(x => x.Forward).IsModified = true;
            this._context.SaveChanges();

            return p;
        }
    }
}
