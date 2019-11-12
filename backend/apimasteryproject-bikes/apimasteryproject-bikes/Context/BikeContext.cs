using apimasteryproject_bikes.Models;
using Microsoft.EntityFrameworkCore;

namespace apimasteryproject_bikes.Context
{
    public class BikeContext : DbContext
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Bicycle> Bicycles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=apimasteryproject-bikes;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString)
            .UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer(1, "Specialized", "Logo", "Description")
                );

            modelBuilder.Entity<Bicycle>().HasData(
                new Bicycle(1, "Tarmac", "Image", "Description", "Road", 1)
                );
            base.OnModelCreating(modelBuilder);
        }

    }
}
