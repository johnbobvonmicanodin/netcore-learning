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

            mock.Setup(p => p.AddInventory(It.IsAny<Inventory>()))
             .Returns(newInv);

            var service = new InventoryService(mock.Object);
            var repInv = service.AddInventory(newInv);

            Assert.IsTrue(repInv == null);
        }

        [TestMethod]
        public void AddInventoryWithNegativeStock()
        {    
            var mock = new Mock<IInventoryRepository>();
            var mockprod = new Mock<IProductRepository>();
            var newProd = new Product() { Id = new Guid("08d67f25-7d67-8d8c-3d56-1d869bf16282"), TVA = 10, PriceHT = 50};
            var newInv = new Inventory() { Stock = -1, ProductStock = newProd, Date = new DateTime() };

            mockprod.Setup(p => p.AddProduct(It.IsAny<Product>()))
             .Returns(newProd);

            mock.Setup(p => p.AddInventory(It.IsAny<Inventory>()))
              .Returns(newInv);

            var service = new InventoryService(mock.Object);
            var repInv = service.AddInventory(newInv);

            Assert.IsTrue(repInv.Stock == 0);
        }

        [TestMethod]
        public void GetInventoryFromProductNotInDatabase()
        {
            var mock = new Mock<IInventoryRepository>();      
            var newProd = new Product() { TVA = 10, PriceHT = 50 };
        
            var service = new InventoryService(mock.Object);
            var repInv = service.GetLastInventory(newProd);

            Assert.IsTrue(repInv == null);
        }

    }
}
