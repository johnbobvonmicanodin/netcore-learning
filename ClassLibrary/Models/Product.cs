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
        public int Delivery_time { get; set; }
        public double TVA { get; set; }
        public double PriceHT { get; set; }
        public string Stock_place { get; set; }

        public Product()
        {

        }
    }
}
