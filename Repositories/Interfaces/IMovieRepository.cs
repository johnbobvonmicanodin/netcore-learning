using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();

        Movie AddMovie(Movie m);

        bool DeleteMovie(Guid id);

        Movie Update(Guid id, Movie m);
    }
}
