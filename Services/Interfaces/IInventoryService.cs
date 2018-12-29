using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace Repositories.Interfaces
{
    public interface IInventoryService
    { 

        Inventory AddInventory(Inventory i);

        Inventory GetLastInventory(Product p);

        List<Inventory> GetAllLastInventory();

        void DeleteInventory(Inventory);

    }
}
