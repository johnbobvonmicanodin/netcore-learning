using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Movement
    {
        public Guid Id { get; set; }
        public Product ProductMoved { get; set; }
        public string Type_of_movement { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
       
        public Movement()
        {

        }
    }
}
