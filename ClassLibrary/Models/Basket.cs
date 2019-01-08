using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Basket
    {
        public Guid Id { get; set; }
        public User BasketOwner { get; set; }
        public string Product_name { get; set; }
        public int Number { get; set; }
       
        public Basket()
        {

        }
    }
}
