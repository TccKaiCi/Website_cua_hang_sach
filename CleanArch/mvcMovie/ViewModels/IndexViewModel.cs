using Microsoft.AspNetCore.Mvc.Rendering;
using Application.DTOs;
using Domain.Entities.Helpers;

namespace mvcMovie.ViewModels
{
    public class IndexViewModel
    {
        public PaginatedList<MovieDto> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
        public string SortOrder { get; set; }
    }
}