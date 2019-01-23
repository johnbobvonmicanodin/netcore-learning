using ClassLibrary.Models;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace Repositories.Repositories
{
    public class MovementRepository : IMovementRepository
    {
        private readonly KlaydSoulDbContext _context;

        public MovementRepository(KlaydSoulDbContext context)
        {
            this._context = context;
        }

        public Movement AddMovement(Movement m)
        {
            this._context.Attach(m);
            this._context.SaveChanges();

            return m;
        }

        public List<Movement> GetAllMovementofOneProduct(Product p)
        {
            return _context.Movements.Include(m => m.MovementOrigin).Include(m => m.ProductMoved).Where(m => m.ProductMoved == p).ToList();
        }

        public List<Movement> GetAllMovementOneProductAfterInventory(Product p)
        {
            InventoryRepository _inventoryRepo = new InventoryRepository(this._context);
            Inventory i = _inventoryRepo.GetLastInventory(p);

            return this._context.Movements.Include(m => m.MovementOrigin).Include(m => m.ProductMoved).Where(m => m.ProductMoved == p && m.Date >= i.Date).ToList();
        }

        public List<Movement> GetAllMovementOneUser(User u)
        {
            return this._context.Movements.Include(m => m.MovementOrigin).Include(m => m.ProductMoved).Where(m => m.MovementOrigin == u && m.Type_of_movement == "purchase").ToList();
        }

        public List<Movement> GetAllMovementPurchase()
        {
            return this._context.Movements.Include(m => m.MovementOrigin).Include(m => m.ProductMoved).Where(m => m.Type_of_movement == "purchase").ToList();
        }

        public void ResetAllMovement(Product p)
        {
            this._context.Movements.RemoveRange(this._context.Movements.Where(m => m.ProductMoved == p));
            this._context.SaveChanges();
        }
    }
}
