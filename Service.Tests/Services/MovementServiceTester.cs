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
    }
}
