using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Repositories;

namespace Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public IEnumerable<MovieDto> GetMovies(string sortOrder, string movieGenre, string searchString, int pageIndex, int pageSize, out int count)
        {
            var movies = movieRepository.Filter(sortOrder, movieGenre, searchString, pageIndex, pageSize, out count);

            return movies.MappingDtos();
        }

        public MovieDto GetMovie(int movieId)
        {
            var movie = movieRepository.GetBy(movieId);

            return movie.MappingDto();
        }

        public IEnumerable<string> GetGenres()
        {
            return movieRepository.GetGenres();
        }

        public void CreateMovie(MovieDto movieDto)
        {
            var movie = movieDto.MappingMovie();
            movieRepository.Add(movie);
        }

        public void UpdateMovie(MovieDto movieDto)
        {
            var movie = movieRepository.GetBy(movieDto.Id);

            movieDto.MappingMovie(movie);

            movieRepository.Update(movie);
        }

        public void DeleteMovie(int movieId)
        {
            var movie = movieRepository.GetBy(movieId);

            movieRepository.Delete(movie);
        }
    }
}