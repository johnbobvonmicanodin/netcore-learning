using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using Repositories.Repositories;
using Services.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet("get")]
        public User GetUser(String mail, String password)
        {

            return _userService.GetUser(mail, password);
        }

        [HttpPost("add")]
        public User AddUser(User u)
        {
            return _userService.AddUser(u);
        }

        [HttpDelete("/delete")]
        public bool DeleteUser(Guid id)
        {
            return _userService.DeleteUser(id);
        }


    }
}