using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace Repositories.Interfaces
{
    public interface IProductRepository
    {
        Basket AddProduct(Product p);

        List<Product> GetAllProduct();

        void DeleteProduct(Product p);

    }
}
