using System.Reflection;
using Domain.Entities;
using Domain.Entities.CustomerAggregate;
using Domain.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; } 
        public DbSet<Order> Orders { get; set; } 
        public DbSet<PersonalCustomer> PersonalCustomers { get; set; } 
        public DbSet<CorporateCustomer> CorporateCustomers { get; set; } 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}