using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace Repositories.Interfaces
{
    public interface IProductService
    {
        Product AddProduct(Product p);

        List<Product> GetAllProduct();

        void DeleteProduct(Product p);

    }
}
