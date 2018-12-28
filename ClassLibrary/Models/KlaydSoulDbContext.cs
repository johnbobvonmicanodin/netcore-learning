using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class KlaydSoulDbContext : DbContext
    {
        public virtual DbSet<Movie> Movies { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Inventory> Inventories { get; set; }
        
        public virtual DbSet<Movement> Movements { get; set; }

        public virtual DbSet<Basket> Baskets { get; set; }

        public KlaydSoulDbContext()
        {

        }

        public KlaydSoulDbContext(DbContextOptions<KlaydSoulDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;port=3306;database=core;uid=root;password=root");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>()
                .HasMany(bc => bc.DirectedMovies)
                .WithOne(x => x.Director)
                ;

            modelBuilder.Entity<Movie>()
                .HasMany(x => x.Actors)
                .WithOne(x => x.Movie)
                ;
            modelBuilder.Entity<Person>()
                .HasMany(x => x.PlayedMovies)
                .WithOne(x => x.Actor)
                ;
        
            modelBuilder.Entity<MovieActor>().HasKey(x => new { x.ActorId, x.MovieId });
        }
    }
}
