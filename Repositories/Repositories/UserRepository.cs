using ClassLibrary.Models;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly KlaydSoulDbContext _context;

        public UserRepository(KlaydSoulDbContext context)
        {
            this._context = context;
        }

        public User GetUser(String mail, String password)
        {
            User u = this._context.Users.SingleOrDefault(i => i.Email == mail);

            if(u.Password == password){
                return u;
            }
            else
            {
                return null;
            }
           
        }

        public User AddUser(User u)
        {
            User alreadyExist = this._context.Users.SingleOrDefault(i => i.Email == u.Email);

            if (alreadyExist == null)
            {
                this._context.Attach(u);
                this._context.SaveChanges();
                return u;
            }
            else
            {
                return null;
            }
        }

        public List<User> GetAllUsers()
        {
            return this._context.Users.ToList();
        }

        public bool DeleteUser(Guid id)
        {
            if (this._context.Users.FirstOrDefault(i => i.id == id) != null)
            {
                this._context.Users.Remove(this._context.Users.FirstOrDefault(i => i.id == id));
                this._context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
