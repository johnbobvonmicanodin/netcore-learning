using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repositories.Interfaces;
using Repositories.Repositories;
using Services.Services;
using ClassLibrary.Models;
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

        [TestMethod]
        public void AddUserWithSameEmail()
        {
            var mock = new Mock<IUserRepository>();
            var newUser = new User() { Email = "test@test.fr", Name = "Mathieu", FirstName = "Mathieu" };

            var service = new UserService(mock.Object);
            var repUser = service.AddUser(newUser);

            Assert.IsTrue(repUser == null);
        }


        [TestMethod]
        public void LoginWithNullLogs()
        {
            var mock = new Mock<IUserRepository>();
            var newUser = new User();

            var service = new UserService(mock.Object);
            var repUser = service.GetUser(newUser.Email, newUser.Password);

            Assert.IsTrue(repUser == null);
        }


        [TestMethod]
        public void DeleteUserThatDontExist()
        {
            var mock = new Mock<IUserRepository>();
            var newUser = new User();

            var service = new UserService(mock.Object);
            Assert.IsTrue(service.DeleteUser(newUser.Id) == false);
        }

        [TestMethod]
        public void UpdateUserThatDontExist()
        {
            var mock = new Mock<IUserRepository>();
            var newUser = new User();
            var updateUser = new User();

            var service = new UserService(mock.Object);
            Assert.IsTrue(service.UpdateUser(newUser, updateUser) == null);

        }
    }
}
