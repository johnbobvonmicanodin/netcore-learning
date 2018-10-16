using ClassLibrary.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository mr)
        {
            this._movieRepository = mr;
        }

        public Movie AddMovie(Movie movie)
        {
            Movie m = this.GetByTitle(movie.Title);

            if(this.GetByTitle(movie.Title) == null && movie.Date.Year > 1980)
            {
                return _movieRepository.AddMovie(movie);
            }
            else
            {
                return null;
            }
           
        }

        public bool DeleteMovie(Guid id)
        {

            return _movieRepository.DeleteMovie(id);
        }

        public List<Movie> GetAllMovies()
        {
            return _movieRepository.GetAllMovies();
        }

        public Movie GetByTitle(string title)
        {
            return _movieRepository.GetByTitle(title);
        }

        public Movie Update(Guid id, Movie m)
        {
            return _movieRepository.Update(id, m);
        }
    }
}
