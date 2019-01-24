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
    }
}
