using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace Repositories.Interfaces
{
    public interface IUserRepository
    {
        User AddUser(User m);

        User UserExist(User u);

        User GetUser(String mail);

        List<User> GetAllUsers();

        bool DeleteUser(Guid id);

    }
}
