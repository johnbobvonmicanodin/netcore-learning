using ClassLibrary.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
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
            u.Password = Sha256_hash(u.Password);

            User exist = _userRepository.UserExist(u);
            
            if(exist != null)
            {
                return _userRepository.AddUser(u);
            }
            else
            {
                return null;
            }
            
        }

        public User GetUser(string email, string password)
        {
            if (password != null && email != null)
            {
                password = Sha256_hash(password);

                User u = _userRepository.GetUser(email);

                if (u.Password == password)
                {
                    return u;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public bool DeleteUser(Guid id)
        { 
            return _userRepository.DeleteUser(id);
        }

        public static string Sha256_hash(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
