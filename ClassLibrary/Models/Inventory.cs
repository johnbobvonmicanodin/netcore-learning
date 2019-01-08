using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Inventory
    {
        public Guid Id { get; set; }
        public Product ProductStock { get; set; }
        public int Stock { get; set; }
        public DateTime Date { get; set; }
       
        public Inventory()
        {

        }
    }
}
