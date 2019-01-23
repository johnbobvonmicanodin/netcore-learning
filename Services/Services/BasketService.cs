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
            return this._basketRepository.AddItem(b);
        }

        public bool DeleteAllBasket(User u)
        {
            return this._basketRepository.DeleteAllBasket(u);
        }

        public bool DeleteBasket(Basket b)
        {
            return this._basketRepository.DeleteBasket(b);
        }

        public List<Basket> GetAllBasketUser(User u)
        {
            return this._basketRepository.GetAllBasketUser(u);
        }
    }
}
