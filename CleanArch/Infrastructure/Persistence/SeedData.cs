using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;

namespace Infrastructure.Persistence
{
    public class SeedData
    {
        public static void Initialize(MovieContext context)
        {
            context.Database.EnsureCreated();

            if (context.Movies.Any()) return;

            context.Movies.AddRange(new List<Movie>{
                new Movie {
                    Title = "When Harry met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "R"
                },
                new Movie {
                    Title = "Ghostbuster",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "PG-13"
                },
                new Movie {
                    Title = "Ghostbuster 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "PG"
                },
                new Movie {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "G"
                }
            });

            context.SaveChanges();
        }
    }
}