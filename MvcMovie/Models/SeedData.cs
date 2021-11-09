using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Price = 7.99M,
                        Rating = "PG",
                        MovieImage = "~/images/Meet.jpg"
                    },

                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG",
                        MovieImage = "~/images/TheRM.jpg"
                    },

                    new Movie
                    {
                        Title = "God's Army",
                        ReleaseDate = DateTime.Parse("2000-3-10"),
                        Genre = "Missionary",
                        Price = 9.99M,
                        Rating = "PG",
                        MovieImage = "~/images/GodsArmy.jpg"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Romance",
                        Price = 3.99M,
                        Rating = "PG",
                        MovieImage = "~/images/OtherSide.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
        }
}
