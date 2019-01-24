using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using Repositories.Repositories;
using Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]"), EnableCors("AllowAllOrigins")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        private readonly IHostingEnvironment _hostingEnvironment;

        public ProductsController(IHostingEnvironment env, IProductService productService)
        {
            this._productService = productService;

            this._hostingEnvironment = env;
        }

        [HttpGet("get")]
        public List<Product> GetAllProduct()
        {
            return this._productService.GetAllProduct();
        }

        [HttpPost("add")]
        public Product AddProduct(Product p)
        {
            return this._productService.AddProduct(p);
        }

        [HttpPost("update")]
        public Product UpdateProduct(Product p)
        {
            return this._productService.UpdateProduct(p);
        }

        [HttpGet("getallup")]
        public List<Product> GetAllProductUp()
        {
            return this._productService.GetAllProductUp();
        }

        [HttpGet("getallforward")]
        public List<Product> GetAllProductForward()
        {
            return this._productService.GetAllProductForward();
        }

        [HttpPost("setup")]
        public Product SetProductUp(Product p)
        {
            return this._productService.SetProductUp(p);
        }

        [HttpPost("setforward")]
        public Product SetProductForward(Product p)
        {
            return this._productService.SetProductForward(p);
        }

        [HttpPost("addimage")]
        public Product AddImage()
        {
            var image = Request.Form.Files[0];
            string folder = "images";
            string host = _hostingEnvironment.WebRootPath;
            string path = Path.Combine(host, folder);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (image.Length > 0)
            {
                string fileName = ContentDispositionHeaderValue.Parse(image.ContentDisposition).FileName.Trim('"');
                string fullPath = Path.Combine(path, fileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }
            }

            return new Product();

        }

        [HttpPost("delete")]
        public bool DeleteProduct(Product p)
        {
            return this._productService.DeleteProduct(p);
        }
    }
}