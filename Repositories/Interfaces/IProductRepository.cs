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

        List<Product> GetAllProductUp();

        List<Product> GetAllProductForward();

        bool DeleteProduct(Product p);

        Product UpdateProduct(Product p);

        Product SetProductUp(Product p);

        Product SetProductForward(Product p);

    }
}
