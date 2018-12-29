﻿using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace Repositories.Interfaces
{
    public interface IUserRepository
    {
        User AddUser(User m);

        List<User> GetAllUsers();
    }
}
