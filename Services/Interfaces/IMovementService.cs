using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace Repositories.Interfaces
{
    public interface IMovementService
    {
        Basket AddMovement(Movement m);

        List<Basket> GetAllMovementofOneProduct(Product p);

        void ResetAllMovement(Product p);

    }
}
