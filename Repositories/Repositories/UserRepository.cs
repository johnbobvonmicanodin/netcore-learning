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

        public User AddUser(User m)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
