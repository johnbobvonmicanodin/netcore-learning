using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IMovieService
    {
      
        List<Movie> GetAllMovies();

        Movie AddMovie(Movie m);

        bool DeleteMovie(Guid id);

        Movie Update(Guid id, Movie m);

        Movie GetByTitle(string title);
    }
}

