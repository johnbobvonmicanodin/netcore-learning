using ClassLibrary.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository ur)
        {
            this._userRepository = ur;
        }

        public User AddUser(User u)
        {
            //check si deja present etc
            return _userRepository.AddUser(u);
        }

        public User GetUser(String email, string password)
        {
            return _userRepository.GetUser(email, password);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public bool DeleteUser(Guid id)
        { 
            return _userRepository.DeleteUser(id);
        }
    }
}
