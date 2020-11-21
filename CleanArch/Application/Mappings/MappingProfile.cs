using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class MappingProfile
    {
        public static MovieDto MappingDto(this Movie movie)
        {
            return new MovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                ReleaseDate = movie.ReleaseDate,
                Genre = movie.Genre,
                Price = movie.Price,
                Rating = movie.Rating
            };
        }

        public static Movie MappingMovie(this MovieDto movieDto)
        {
            return new Movie
            {
                Id = movieDto.Id,
                Title = movieDto.Title,
                ReleaseDate = movieDto.ReleaseDate,
                Genre = movieDto.Genre,
                Price = movieDto.Price,
                Rating = movieDto.Rating
            };
        }

        public static void MappingMovie(this MovieDto movieDto, Movie movie)
        {
            movie.Title = movieDto.Title;
            movie.ReleaseDate = movieDto.ReleaseDate;
            movie.Genre = movieDto.Genre;
            movie.Price = movieDto.Price;
            movie.Rating = movieDto.Rating;
        }

        public static IEnumerable<MovieDto> MappingDtos(this IEnumerable<Movie> movies)
        {
            foreach (var movie in movies)
            {
                yield return movie.MappingDto();
            }
        }

    }
}
