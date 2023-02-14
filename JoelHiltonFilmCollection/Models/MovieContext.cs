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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormResponse>().HasData(
                new FormResponse
                {
                    FormId = 1,
                    Category = "Science Fiction",
                    Title = "A New Hope",
                    Year = 1978,
                    Director = "George Lucas",
                    Rating = "PG-13",
                    Edited = false
                },
                new FormResponse
                {
                    FormId = 2,
                    Category = "Science Fiction",
                    Title = "The Empire Strikes Back",
                    Year = 1980,
                    Director = "Irvin Kershner",
                    Rating = "PG-13",
                    Edited = false
                },
                new FormResponse
                {
                    FormId = 3,
                    Category = "Science Fiction",
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
