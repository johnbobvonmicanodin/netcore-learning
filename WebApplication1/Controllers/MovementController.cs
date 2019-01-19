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
    public class MovementsController : ControllerBase
    {
        private readonly IMovementService _movementService;

        public MovementsController(IMovementService movementService)
        {
            this._movementService = movementService;
        }

        [HttpPost("add")]
        public Movement AddMovement(Movement m)
        {
            return this._movementService.AddMovement(m);
        }

        [HttpPost("getalloneproduct")]
        public List<Movement> GetAllOfOneProduct(Product p)
        {
            return this._movementService.GetAllMovementofOneProduct(p);
        }

        [HttpPost("getalloneproductafterlastinventory")]
        public List<Movement> GetAllOfOneProductAfterInventory(Product p)
        {
            return this._movementService.GetAllMovementOneProductAfterInventory(p);
        }
    }
}