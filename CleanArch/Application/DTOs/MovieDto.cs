using System;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Genre { get; set; }

        public decimal Price { get; set; }

        [Required]
        public string Rating { get; set; }
    }
}