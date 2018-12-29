using ClassLibrary.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryService(IInventoryRepository iv)
        {
            this._inventoryRepository = iv;
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
