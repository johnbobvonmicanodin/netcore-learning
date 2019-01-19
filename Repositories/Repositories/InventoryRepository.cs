using ClassLibrary.Models;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly KlaydSoulDbContext _context;

        public InventoryRepository(KlaydSoulDbContext context)
        {
            this._context = context;
        }

        public Inventory AddInventory(Inventory i)
        {
            this._context.Attach(i);
            this._context.SaveChanges();

            return i;
        }

        public Boolean DeleteInventory(Inventory inv)
        {
            if (this._context.Inventories.FirstOrDefault(i => i.Id == inv.Id) != null)
            {
                this._context.Inventories.Remove(this._context.Inventories.FirstOrDefault(i => i.Id == inv.Id));
                this._context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Inventory> GetAllLastInventory()
        {
            List<Inventory> allLastInventory = new List<Inventory>();

            ProductRepository productRepository = new ProductRepository(this._context);

            List<Product> allProduct = productRepository.GetAllProduct();

            foreach(Product p in allProduct)
            {
                allLastInventory.Add(this._context.Inventories.FirstOrDefault(i => i.ProductStock == p));
            }

            return allLastInventory;
        }

        public Inventory GetLastInventory(Product p)
        {
            return this._context.Inventories.FirstOrDefault(i => i.ProductStock == p);
        }
    }
}
