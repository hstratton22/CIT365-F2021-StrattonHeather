using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(serviceProvider.GetRequiredService<DbContextOptions<MyScriptureJournalContext>>()))
            {
                //Look for any scriptures
                if (context.Scripture.Any())
                {
                    return; //DB has been seeded
                }
                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "Doctrine and Covenants",
                        Chapter = "121",
                        Verse = "40",
                        Notes = "We are not chosen if we don't choose to be disciples of Christ.",
                        AddedDate = DateTime.Parse("2021-10-20"),
                        Topic = "choose"

                    },
                    new Scripture
                    {
                        Book = "1 Nephi",
                        Chapter = "3",
                        Verse = "7",
                        Notes = "Am I willing to do ALL that is asked of me?",
                        AddedDate = DateTime.Parse("2021-10-21"),
                        Topic = "willing"
                    },
                    new Scripture
                    {
                        Book = "Moroni",
                        Chapter = "10",
                        Verse = "4-5",
                        Notes = "First must be willing to receive and then willing to ask and listen",
                        AddedDate = DateTime.Parse("2021-10-22"),
                        Topic = "ask, know"

                    },
                    new Scripture
                    {
                        Book = "2 Nephi",
                        Chapter = "2",
                        Verse = "25",
                        Notes = "Am I actively choosing joy?",
                        AddedDate = DateTime.Parse("2021-10-25"),
                        Topic = "choose, joy"
                    },
                    new Scripture
                    {
                        Book = "2 Nephi",
                        Chapter = "4",
                        Verse = "16",
                        Notes = "Let go of anxiety and delight in the things of the Lord.",
                        AddedDate = DateTime.Parse("2021-10-25"),
                        Topic = "delight"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
