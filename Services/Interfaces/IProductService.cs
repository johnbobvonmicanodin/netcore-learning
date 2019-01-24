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

        bool DeleteProduct(Product p);

        Product UpdateProduct(Product p);

        List<Product> GetAllProductUp();

        List<Product> GetAllProductForward();

        Product SetProductUp(Product p);

        Product SetProductForward(Product p);
    }
}
