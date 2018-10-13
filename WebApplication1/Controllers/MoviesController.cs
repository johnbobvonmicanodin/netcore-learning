using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using Repositories.Repositories;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movieService;

        public MoviesController(IMovieRepository movieService)
        {
            this._movieService = movieService;
        }

        [HttpGet("")]
        public List<Movie> GetAllMovies()
        {
            //StaticMovieRepository repo = new StaticMovieRepository();

            return _movieService.GetAllMovies();
        }

        [HttpDelete("/delete")]
        public bool DeleteMovie(Guid id)
        {
            return _movieService.DeleteMovie(id);
        }

        [HttpPut("/add")]
        public Movie AddMovie(Movie m)
        {
            return _movieService.AddMovie(m);
        }

        [HttpPost("/update")]
        public Movie UpdateMovie(Guid id, Movie m)
        {
            return _movieService.Update(id, m);
        }
    }
}