using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Basket
    {
        public Guid Id { get; set; }
        public User BasketOwner { get; set; }
        public Product Product_choose { get; set; }
        public int Number { get; set; }
       
        public Basket()
        {

        }
    }
}
