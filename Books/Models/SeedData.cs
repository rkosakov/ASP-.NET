using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Books.Data;
using System;
using System.Linq;


namespace Books.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BooksContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BooksContext>>()))
            {
                // Look for any movies in database
                if (context.Book.Any())
                {
                    return;   // Database has been seeded
                }
                context.Book.AddRange(
                    new Book
                    {
                        Title = "Catch-22",
                        Author = "Joseph Heller",
                        Publisher = "Simon & Schuster",
                        PublicationDate = DateTime.Parse("1961-11-10")
                    },

                    new Book
                    {
                        Title = "The Hitch-Hiker's Guide to the Galaxy",
                        Author = "Douglas Adams",
                        Publisher = "Pan Books",
                        PublicationDate = DateTime.Parse("1979-10-12")
                    },

                    new Book
                    {
                        Title = "The Hobbit",
                        Author = "J.R.R. Tolkien",
                        Publisher = "George Allen & Unwin",
                        PublicationDate = DateTime.Parse("1937-9-21")
                    },

                    new Book
                    {
                        Title = "The Selection",
                        Author = "Violeta Kosakova",
                        Publisher = "Sam & Sam",
                        PublicationDate = DateTime.Parse("2010-3-21")

                    },

                    new Book
                    {
                        Title = "The Heroes today",
                        Author = "Vasil Kosakov",
                        Publisher = "Whale Books",
                        PublicationDate = DateTime.Parse("2009-8-30")
                    },

                    new Book
                    {
                        Title = "The Choice",
                        Author = "Violeta Kosakova",
                        Publisher = "Sam & Sam",
                        PublicationDate = DateTime.Parse("2015-7-21")
                    },

                    new Book
                    {
                        Title = "How to be a Hero today",
                        Author = "Vasil Kosakov",
                        Publisher = "Whale Books",
                        PublicationDate = DateTime.Parse("2017-6-5")
                    }

                ); 
                context.SaveChanges();

            }

        }
    }
}
