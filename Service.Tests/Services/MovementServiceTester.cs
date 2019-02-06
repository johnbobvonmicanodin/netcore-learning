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
    public class MovementServiceTester
    {
        private IMovementRepository _movementRepository;
        private IMovementService _movementService;

        public MovementServiceTester()
        {
            _movementRepository = new MovementRepository(null);
            _movementService = new MovementService(_movementRepository);
        }

        [TestMethod]
        public void AddMovementWithoutOwner()
        {
            var mock = new Mock<IMovementRepository>();
            var newMov = new Movement() { ProductMoved = null };

            var service = new MovementService(mock.Object);
            var repMov = service.AddMovement(newMov);

            Assert.IsTrue(repMov == null);
        }


        [TestMethod]
        public void AddMovementWithoutProduct()
        {
            var mock = new Mock<IMovementRepository>();
            var newMov = new Movement() { MovementOrigin = null };

            var service = new MovementService(mock.Object);
            var repMov = service.AddMovement(newMov);

            Assert.IsTrue(repMov == null);
        }


        [TestMethod]
        public void GetListWithProductUndefined()
        {
            var mock = new Mock<IMovementRepository>();

            var newProd = new Product() { Name = "productwithoutname" };

            var service = new MovementService(mock.Object);
            var repMov = service.GetAllMovementofOneProduct(newProd);

            Assert.IsTrue(repMov == null);
        }


        [TestMethod]
        public void GetListAfterInventoryWithProductUndefined()
        {
            var mock = new Mock<IMovementRepository>();

            var newProd = new Product() { Name = "productwithoutname" };

            var service = new MovementService(mock.Object);
            var repMov = service.GetAllMovementOneProductAfterInventory(newProd);

            Assert.IsTrue(repMov == null);
        }

        [TestMethod]
        public void MovementofOneUserUndefined()
        {
            var mock = new Mock<IMovementRepository>();

            var user = new User() { Name = "Gilbert", Email = "leplusgranddesheros@outlook.com" };

            var service = new MovementService(mock.Object);
            var repMov = service.GetAllMovementOneUser(user);

            Assert.IsTrue(repMov == null);
        }
    }
}
