using ClassLibrary.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class AuthController:Controller
    {
        private readonly IConfiguration _config;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AuthentificationHelper auth;

        public AuthController(IConfiguration config, IHttpContextAccessor httpContextAccessor)
        {
            _config = config;
            _httpContextAccessor = httpContextAccessor;
            auth = new AuthentificationHelper(_config);
        }

        [AllowAnonymous, HttpPost("login")]
        public IActionResult CreateToken([FromBody]User login)
        {
            IActionResult response = Unauthorized();
            var user = auth.Authenticate(login);

            if (user == null) return response;
            var tokenString = auth.BuildToken(user);
            response = Ok(new { token = tokenString });
            return response;
        }

        [HttpGet("me")]
        public IActionResult MySelf()
        {
            var currentUser = _httpContextAccessor.HttpContext.User;
            var email = currentUser.FindFirst(ClaimTypes.NameIdentifier);

            if(currentUser == null || email == null)
            {
                return BadRequest("I don't know you");
            }

            return Ok(email.Value);

        }

    }
}
