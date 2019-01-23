using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace Repositories.Interfaces
{
    public interface IBasketRepository
    {
        Basket AddItem(Basket b);

        List<Basket> GetAllBasketUser(User u);

        Boolean DeleteBasket(Basket b);

        bool DeleteAllBasket(User u);
    }
}
