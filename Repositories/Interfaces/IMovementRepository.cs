using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace Repositories.Interfaces
{
    public interface IMovementRepository
    {
        Movement AddMovement(Movement m);

        List<Movement> GetAllMovementofOneProduct(Product p);

        List<Movement> GetAllMovementOneProductAfterInventory(Product p);

        void ResetAllMovement(Product p);

    }
}
