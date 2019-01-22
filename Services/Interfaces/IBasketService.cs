using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace Repositories.Interfaces
{
    public interface IBasketService
    {
        Basket AddItem(Basket b);

        List<Basket> GetAllBasketUser(User u);

        bool DeleteBasket(Basket b);

        void DeleteAllBasket(User u);
    }
}
