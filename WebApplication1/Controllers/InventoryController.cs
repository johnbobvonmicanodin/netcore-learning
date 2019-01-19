using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using Repositories.Repositories;
using Services.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]"), EnableCors("AllowAllOrigins")]
    [ApiController]
    public class InventoriesController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoriesController(IInventoryService inventoryService)
        {
            this._inventoryService = inventoryService;
        }


        [HttpPost("add")]
        public Inventory AddInventory(Inventory i)
        {
            return this._inventoryService.AddInventory(i);
        }

        [HttpDelete("delete")]
        public void DeleteInventory(Inventory i)
        {
            this._inventoryService.DeleteInventory(i);
        }

        [HttpGet("getalllast")]
        public List<Inventory> GetAllLastInventory()
        {
            return this._inventoryService.GetAllLastInventory();
        }

        [HttpPost("getlast")]
        public Inventory GetLastInventory(Product p)
        {
            return this._inventoryService.GetLastInventory(p);
        }
    }
}