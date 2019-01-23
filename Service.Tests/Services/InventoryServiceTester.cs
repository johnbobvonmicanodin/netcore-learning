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
    }
}
