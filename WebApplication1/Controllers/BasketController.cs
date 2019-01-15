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
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketsController(IBasketService basketService)
        {
            this._basketService = basketService;
        }


        [HttpPost("getforuser")]
        public List<Basket> GetForUser(User u)
        {
            return this._basketService.GetAllBasketUser(u);
        }

        [HttpPost("add")]
        public Basket AddBasket(Basket b)
        {
            return this._basketService.AddItem(b);
        }

    }
}