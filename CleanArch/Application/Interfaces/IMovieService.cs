using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<MovieDto> GetMovies(string sortOrder, string movieGenre, string searchString, int pageIndex, int pageSize, out int count);
        MovieDto GetMovie(int movieId);
        IEnumerable<string> GetGenres();
        void CreateMovie(MovieDto movie);
        void UpdateMovie(MovieDto movie);
        void DeleteMovie(int movieId);
    }
}