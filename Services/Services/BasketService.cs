using ClassLibrary.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepository _basketRepository;

        public BasketService(IBasketRepository bk)
        {
            this._basketRepository = bk;
        }

        public Basket AddItem(Basket b)
        {
            throw new NotImplementedException();
        }

        public void DeleteAllBasket(User u)
        {
            throw new NotImplementedException();
        }

        public void DeleteBasket(Basket b)
        {
            throw new NotImplementedException();
        }

        public List<Basket> GetAllBasketUser(User u)
        {
            throw new NotImplementedException();
        }
    }
}
