using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public double Price { get; set; }
        public string Stock_place { get; set; }

        public Product()
        {

        }
    }
}
