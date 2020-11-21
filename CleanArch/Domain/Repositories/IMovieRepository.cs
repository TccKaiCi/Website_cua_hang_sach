using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        IEnumerable<string> GetGenres();
        IEnumerable<Movie> Filter(string sortOrder, string movieGenre, string searchString, int pageIndex, int pageSize, out int count);
    }
}