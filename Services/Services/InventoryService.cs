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
            return this._inventoryRepository.AddInventory(i);
        }

        public void DeleteInventory(Inventory i)
        {
            this._inventoryRepository.DeleteInventory(i);
        }

        public List<Inventory> GetAllLastInventory()
        {
            return this._inventoryRepository.GetAllLastInventory();
        }

        public Inventory GetLastInventory(Product p)
        {
            return this._inventoryRepository.GetLastInventory(p);
        }
    }
}
