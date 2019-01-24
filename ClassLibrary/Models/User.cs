using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int IsSeller { get; set; }
        public string Token { get; set; }

        public User()
        {

        }
    }
}
