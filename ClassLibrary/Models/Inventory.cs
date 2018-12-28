using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Inventory
    {
        public Guid id { get; set; }
        public Guid Product_Name { get; set; }
        public int Stock { get; set; }
        public DateTime Date { get; set; }
       
        public Inventory()
        {

        }
    }
}
