using ClassLibrary.Models;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly KlaydSoulDbContext _context;

        public BasketRepository(KlaydSoulDbContext context)
        {
            this._context = context;
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
