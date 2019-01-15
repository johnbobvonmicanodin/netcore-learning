using ClassLibrary.Models;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Repositories
{
    public class MovementRepository : IMovementRepository
    {
        private readonly KlaydSoulDbContext _context;

        public MovementRepository(KlaydSoulDbContext context)
        {
            this._context = context;
        }

        public Movement AddMovement(Movement m)
        {
            throw new NotImplementedException();
        }

        public List<Movement> GetAllMovementofOneProduct(Product p)
        {
            throw new NotImplementedException();
        }

        public void ResetAllMovement(Product p)
        {
            throw new NotImplementedException();
        }
    }
}
