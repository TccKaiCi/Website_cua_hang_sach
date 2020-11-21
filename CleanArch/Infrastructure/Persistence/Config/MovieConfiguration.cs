using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Config
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(m => m.Title)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(m => m.Genre)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(m => m.Rating)
                .HasMaxLength(5)
                .IsRequired();
        }
    }
}