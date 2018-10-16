using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Person
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Firstname { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Movie> DirectedMovies { get; set; }
        public ICollection<MovieActor> PlayedMovies { get; set; }

        public Person()
        {

        }
    }
}
