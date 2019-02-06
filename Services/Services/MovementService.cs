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
            if(m.MovementOrigin == null || m.ProductMoved == null)
            {
                return null;
            }
            else
            {
                return this._movementRepository.AddMovement(m);
            }     
        }

        public List<Movement> GetAllMovementofOneProduct(Product p)
        {
            if (p.Id == null)
            {
                return null;
            }
            else
            {
                return this._movementRepository.GetAllMovementofOneProduct(p);
            }
        }

        public List<Movement> GetAllMovementOneProductAfterInventory(Product p)
        {
            if (p.Id == null)
            {
                return null;
            }
            else
            {         
                return this._movementRepository.GetAllMovementOneProductAfterInventory(p);
            }
        }

        public List<Movement> GetAllMovementOneUser(User u)
        {
            if(u.Id == null)
            {
                return null;
            }
            else
            {
                return this._movementRepository.GetAllMovementOneUser(u);
            }      
        }

        public List<Movement> GetAllMovementPurchase()
        {
            return this._movementRepository.GetAllMovementPurchase();
        }

        public void ResetAllMovement(Product p)
        {
            this._movementRepository.ResetAllMovement(p);
        }
    }
}
