using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace Repositories.Interfaces
{
    public interface IUserService
    {
        User AddUser(User u);

        User GetUser(String email, string password);

        List<User> GetAllUsers();

        bool DeleteUser(Guid id);

        User UpdateUser(User before, User after);
    }
}
