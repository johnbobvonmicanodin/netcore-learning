using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositories.Interfaces;
using Repositories.Repositories;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Tests.Services
{
    [TestClass]
    public class UserServiceTester
    {
        private IUserRepository _userRepository;
        private IUserService _userService;

        public UserServiceTester()
        {
            _userRepository = new UserRepository(null);
            _userService = new UserService(_userRepository);
        }
    }
}
