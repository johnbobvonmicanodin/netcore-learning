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
            throw new NotImplementedException();
        }

        public void DeleteInventory(Inventory )
        {
            throw new NotImplementedException();
        }

        public List<Inventory> GetAllLastInventory()
        {
            throw new NotImplementedException();
        }

        public Inventory GetLastInventory(Product p)
        {
            throw new NotImplementedException();
        }
    }
}
