using ClassLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repositories.Interfaces;
using Repositories.Repositories;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Tests.Services
{
    [TestClass]
    public class MovieServiceTester
    {
        private IMovieRepository _movieRepository;
        private IMovieService _movieService;

        public MovieServiceTester()
        {
            _movieRepository = new MovieRepository(null);
            _movieService = new MovieService(_movieRepository);
        }

        [TestMethod]
        public void GivenNoMovieWithSameTitle_WhenAddingNewMovie_ThenMovie()
        {
            var mock = new Mock<IMovieRepository>();
            var movie = new Movie() { Title = "ok", Description = "Test" };

            mock.Setup(p => p.GetByTitle(It.IsAny<string>()))
                .Returns<Movie>(null);
            mock.Setup(p => p.AddMovie(It.IsAny<Movie>()))
                .Returns(movie);

            var service = new MovieService(mock.Object);
            var dbMovie = service.AddMovie(movie);

            Assert.IsTrue(dbMovie != null);
        }

        [TestMethod]
        public void GivenMovieWithSameTitle_WhenAddingNewMovie_ThenMovie()
        {
            var mock = new Mock<IMovieRepository>();
            var movie = new Movie() { Title = "Hello World", Description = "Test" };

            mock.Setup(p => p.GetByTitle(It.IsAny<string>()))
                .Returns(It.IsAny<Movie>());
           
            var service = new MovieService(mock.Object);
            var dbMovie = service.AddMovie(movie);

            Assert.IsNull(dbMovie);
        }

        //Test l'unicité des acteurs et des réalisateurs dans la base
        
        //Test des choses 
    }
}
