using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace Repositories.Interfaces
{
    public interface IProductRepository
    {
        Product AddProduct(Product p);

        List<Product> GetAllProduct();

        bool DeleteProduct(Product p);

        Product UpdateProduct(Product p);

    }
}
