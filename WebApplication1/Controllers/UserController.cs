using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using Repositories.Repositories;
using Services.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]"), EnableCors("AllowAllOrigins")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpPost("login")]
        public User LogUser(Login g)
        {
            return _userService.GetUser(g.mail, g.password);
        }

        [HttpPost("add")]
        public User AddUser(User u)
        {
            return _userService.AddUser(u);
        }

        [HttpDelete("delete")]
        public bool DeleteUser(Guid id)
        {
            return _userService.DeleteUser(id);
        }

        [HttpPost("update")]
        public User UpdateUser(ModifyUser u)
        {
            return _userService.UpdateUser(u.before, u.after);
        }

        public class Login
        {
            public string mail;
            public string password;
        }

        public class ModifyUser
        {
            public User before;
            public User after;
        }
    }
}