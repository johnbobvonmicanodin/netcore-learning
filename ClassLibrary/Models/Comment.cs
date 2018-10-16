using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Comment
    {
        public Guid id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Comment()
        {

        }
    }
}
