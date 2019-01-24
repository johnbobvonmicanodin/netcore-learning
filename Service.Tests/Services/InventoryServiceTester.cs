using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repositories.Interfaces;
using Repositories.Repositories;
using Services.Services;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Tests.Services
{
    [TestClass]
    public class InventoryServiceTester
    {
        private IInventoryRepository _inventoryRepository;
        private IInventoryService _inventoryService;

        public InventoryServiceTester()
        {
            _inventoryRepository = new InventoryRepository(null);
            _inventoryService = new InventoryService(_inventoryRepository);
        }

        [TestMethod]
        public void AddInventoryWithoutProduct()
        {
            var mock = new Mock<IInventoryRepository>();
            var newInv = new Inventory() { ProductStock = null };

            var service = new InventoryService(mock.Object);
            var repInv = service.AddInventory(newInv);

            Assert.IsTrue(repInv == null);
        }

        [TestMethod]
        public void AddInventoryWithNegativeStock()
        {
            var mock = new Mock<IInventoryRepository>();
            var newInv = new Inventory() { Stock = -1, ProductStock = { Id = new Guid("08d67f25-7d67-8d8c-3d56-1d869bf16282")}, Date = new DateTime() };

            var service = new InventoryService(mock.Object);
            var repInv = service.AddInventory(newInv);

            Assert.IsTrue(repInv.Stock == 0);
        }

    }
}
