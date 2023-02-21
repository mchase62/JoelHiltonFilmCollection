using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoelHiltonFilmCollection.Models
{
    public class MovieContext : DbContext
    {
        // constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            // leave blank for now
        }

        public DbSet<FormResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; } // lets us reference categories in the controller

        //seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName="Science Fiction" },
                new Category { CategoryID = 2, CategoryName = "Horror" },
                new Category { CategoryID = 3, CategoryName="Romance" },
                new Category { CategoryID = 4, CategoryName = "Comedy" },
                new Category { CategoryID = 5, CategoryName="Drama"}
                );

            mb.Entity<FormResponse>().HasData(
                new FormResponse
                {
                    FormId = 1,
                    CategoryID = 1,
                    Title = "A New Hope",
                    Year = 1978,
                    Director = "George Lucas",
                    Rating = "PG-13",
                    Edited = false
                },
                new FormResponse
                {
                    FormId = 2,
                    CategoryID = 1,
                    Title = "The Empire Strikes Back",
                    Year = 1980,
                    Director = "Irvin Kershner",
                    Rating = "PG-13",
                    Edited = false
                },
                new FormResponse
                {
                    FormId = 3,
                    CategoryID = 1,
                    Title = "Return of the Jedi",
                    Year = 1983,
                    Director = "Richard Marquand",
                    Rating = "PG-13",
                    Edited = false
                }
            );
        }
    }
}
