using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Models
{
    public class Movie
    {
        public Guid id { get; set; }
        public string Title { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public float Duration { get; set; }
        public string Description { get; set; }
        public Person Director { get; set; }
        public ICollection<MovieActor> Actors { get; set; }
        public ICollection<Comment> Comments { get; set; } 

        public Movie()
        {

        }
    }
}
