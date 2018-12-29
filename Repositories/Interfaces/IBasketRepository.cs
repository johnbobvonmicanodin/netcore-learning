﻿using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace Repositories.Interfaces
{
    public interface IBasketRepository
    {
        Basket AddItem(Basket b);

        List<Basket> GetAllBasketUser(User u);

        void DeleteBasket(Basket b);

        void DeleteAllBasket(User u);
    }
}
