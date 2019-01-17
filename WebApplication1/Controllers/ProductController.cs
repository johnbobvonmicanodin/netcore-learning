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
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet("get")]
        public List<Product> GetAllProducts()
        {
            return this._productService.GetAllProduct();
        }


        [HttpPost("add")]
        public Product AddProduct(Product p)
        {
            return this._productService.AddProduct(p);
        }

        [HttpDelete("delete")]
        public void DeleteProduct(Product p)
        {
            this._productService.DeleteProduct(p);
        }

    }
}