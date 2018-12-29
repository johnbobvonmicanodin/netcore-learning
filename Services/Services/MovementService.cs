using ClassLibrary.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class MovementService : IMovementService
    {
        private readonly IMovementRepository _movementRepository;

        public MovementService(IMovementRepository mv)
        {
            this._movementRepository = mv;
        }

        public Basket AddMovement(Movement m)
        {
            throw new NotImplementedException();
        }

        public List<Basket> GetAllMovementofOneProduct(Product p)
        {
            throw new NotImplementedException();
        }

        public void ResetAllMovement(Product p)
        {
            throw new NotImplementedException();
        }
    }
}
