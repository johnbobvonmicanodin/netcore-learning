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
            this._context.Attach(b);
            this._context.SaveChanges();

            return b;
        }

        public void DeleteAllBasket(User u)
        {
            this._context.Baskets.RemoveRange(this._context.Baskets.Where(b => b.BasketOwner == u));
            this._context.SaveChanges();
        }

        public Boolean DeleteBasket(Basket b)
        {
            if (this._context.Baskets.FirstOrDefault(i => i.Id == b.Id) != null)
            {
                this._context.Baskets.Remove(this._context.Baskets.FirstOrDefault(i => i.Id == b.Id));
                this._context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Basket> GetAllBasketUser(User u)
        {
            return this._context.Baskets.Where(b => b.BasketOwner == u).ToList();
        }
    }
}
