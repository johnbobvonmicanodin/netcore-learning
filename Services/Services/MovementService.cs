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

        public Movement AddMovement(Movement m)
        {
            return this._movementRepository.AddMovement(m);
        }

        public List<Movement> GetAllMovementofOneProduct(Product p)
        {
            return this._movementRepository.GetAllMovementofOneProduct(p);
        }

        public void ResetAllMovement(Product p)
        {
            return this._movementRepository.ResetAllMovement(p);
        }
    }
}
