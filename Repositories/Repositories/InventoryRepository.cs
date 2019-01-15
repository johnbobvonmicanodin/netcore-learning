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
            return this._context.Inventories.ToList();
        }

        public Inventory GetLastInventory(Product p)
        {
            throw new NotImplementedException();
        }
    }
}
