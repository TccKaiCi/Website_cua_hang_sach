using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Persistence
{
    public class MovieRepository : EFRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieContext context) : base(context)
        {
        }

        public IEnumerable<string> GetGenres()
        {
            return context.Movies
                            .OrderBy(m => m.Genre)
                            .Select(m => m.Genre)
                            .Distinct();
        }

        public IEnumerable<Movie> Filter(string sortOrder, string movieGenre, string searchString, int pageIndex, int pageSize, out int count)
        {
            var query = context.Movies.AsQueryable();

            if (!string.IsNullOrEmpty(movieGenre))
            {
                query = query.Where(m => m.Genre == movieGenre);
            }
            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(m => m.Title.Contains(searchString));
            }

            SortMovies(sortOrder, ref query);
            count = query.Count();

            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        private static void SortMovies(string sortOrder, ref IQueryable<Movie> query)
        {
            switch (sortOrder)
            {
                case "title_desc":
                    query = query.OrderByDescending(m => m.Title);
                    break;
                case "title":
                    query = query.OrderBy(m => m.Title);
                    break;
                case "releasedate_desc":
                    query = query.OrderByDescending(m => m.ReleaseDate);
                    break;
                case "releasedate":
                    query = query.OrderBy(m => m.ReleaseDate);
                    break;
                case "genre_desc":
                    query = query.OrderByDescending(m => m.Genre);
                    break;
                case "genre":
                    query = query.OrderBy(m => m.Genre);
                    break;
                case "price_desc":
                    query = query.OrderByDescending(m => m.Price);
                    break;
                case "price":
                    query = query.OrderBy(m => m.Price);
                    break;
                case "rating_desc":
                    query = query.OrderByDescending(m => m.Rating);
                    break;
                case "rating":
                    query = query.OrderBy(m => m.Rating);
                    break;
            }
        }
    }
}