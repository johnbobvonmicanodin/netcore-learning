using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class User
    {
        public Guid id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int isSeller { get; set; }

        public User()
        {

        }
    }
}
