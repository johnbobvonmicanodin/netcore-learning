﻿// <auto-generated />
using System;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClassLibrary.Migrations
{
    [DbContext(typeof(KlaydSoulDbContext))]
    partial class MovieDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ClassLibrary.Models.Basket", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Number");

                    b.Property<string>("Product_name");

                    b.Property<Guid>("User_id");

                    b.HasKey("id");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("ClassLibrary.Models.Comment", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<Guid?>("Movieid");

                    b.Property<string>("Title");

                    b.HasKey("id");

                    b.HasIndex("Movieid");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("ClassLibrary.Models.Inventory", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<Guid>("Product_Name");

                    b.Property<int>("Stock");

                    b.HasKey("id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("ClassLibrary.Models.Movement", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<Guid>("Product_Name");

                    b.Property<string>("Type_of_movement");

                    b.Property<int>("Value");

                    b.HasKey("id");

                    b.ToTable("Movements");
                });

            modelBuilder.Entity("ClassLibrary.Models.Movie", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<Guid?>("Directorid");

                    b.Property<float>("Duration");

                    b.Property<string>("Title");

                    b.HasKey("id");

                    b.HasIndex("Directorid");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("ClassLibrary.Models.MovieActor", b =>
                {
                    b.Property<Guid>("ActorId");

                    b.Property<Guid>("MovieId");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieActor");
                });

            modelBuilder.Entity("ClassLibrary.Models.Person", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Firstname");

                    b.Property<string>("Name");

                    b.HasKey("id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("ClassLibrary.Models.Product", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Picture");

                    b.Property<double>("Price");

                    b.Property<string>("Stock_place");

                    b.HasKey("id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ClassLibrary.Models.User", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<int>("isSeller");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ClassLibrary.Models.Comment", b =>
                {
                    b.HasOne("ClassLibrary.Models.Movie")
                        .WithMany("Comments")
                        .HasForeignKey("Movieid");
                });

            modelBuilder.Entity("ClassLibrary.Models.Movie", b =>
                {
                    b.HasOne("ClassLibrary.Models.Person", "Director")
                        .WithMany("DirectedMovies")
                        .HasForeignKey("Directorid");
                });

            modelBuilder.Entity("ClassLibrary.Models.MovieActor", b =>
                {
                    b.HasOne("ClassLibrary.Models.Person", "Actor")
                        .WithMany("PlayedMovies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClassLibrary.Models.Movie", "Movie")
                        .WithMany("Actors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
