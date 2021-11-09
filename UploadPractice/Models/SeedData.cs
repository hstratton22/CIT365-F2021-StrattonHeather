using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using UploadPractice.Data;

namespace UploadPractice.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UploadPracticeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UploadPracticeContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Title",
                        ReleaseDate = DateTime.Parse("2021-11-9"),
                        Genre = "Genre",
                        Price = 7.99M,
                        PhotoPath = "~/images/placeholder.jpg"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
