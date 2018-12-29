using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace Repositories.Interfaces
{
    public interface IUserService
    {
        User AddUser(User m);

        List<User> GetAllUsers();
    }
}
