using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class MovieActor
    {
        public Guid ActorId { get; set; }
        public Guid MovieId { get; set; }
        public Person Actor { get; set; }
        public Movie Movie { get; set; }
    }
}
