using System;
using Domain.Entities.Common;

namespace Domain.Entities
{
    public class Movie : EntityBase, IAggregateRoot
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}