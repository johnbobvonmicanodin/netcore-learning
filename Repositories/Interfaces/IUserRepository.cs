using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace Repositories.Interfaces
{
    interface IUserRepository
    {
        User AddUser(User m);

        List<User> GetAllUsers();
    }
}
