using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Movement
    {
        public Guid id { get; set; }
        public Guid Product_Name { get; set; }
        public string Type_of_movement { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
       
        public Movement()
        {

        }
    }
}
