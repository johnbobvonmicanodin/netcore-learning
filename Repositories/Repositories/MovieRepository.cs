using ClassLibrary.Models;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly KlaydSoulDbContext _context;

        public MovieRepository(KlaydSoulDbContext context)
        {
            this._context = context;
        }

        public Movie AddMovie(Movie m)
        {
            //this._context.Movies.Add(m);
            this._context.Attach(m);
            this._context.SaveChanges();
            return m;
        }

        public bool DeleteMovie(Guid id)
        {
            if (this._context.Movies.FirstOrDefault(i => i.id == id) != null)
            {
                this._context.Movies.Remove(this._context.Movies.FirstOrDefault(i => i.id == id));
                this._context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Movie> GetAllMovies()
        {
            return this._context.Movies.ToList();
        }

        public Movie GetByTitle(string title)
        {
            return this._context.Movies.SingleOrDefault(i => i.Title == title);
        }

        public Movie Update(Guid id, Movie m)
        {
            Movie up = this._context.Movies.First(i => i.id == id);
            up = m;
            this._context.SaveChanges();
            return m;
        }
    }
}
