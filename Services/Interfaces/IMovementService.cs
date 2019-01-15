using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace Repositories.Interfaces
{
    public interface IMovementService
    {
        Movement AddMovement(Movement m);

        List<Movement> GetAllMovementofOneProduct(Product p);

        void ResetAllMovement(Product p);

    }
}
