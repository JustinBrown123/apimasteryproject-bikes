using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apimasteryproject_bikes.EntityFrameWorkCore;
using apimasteryproject_bikes.Models;

namespace apimasteryproject_bikes.Context
{
    public class BikeContext : DbContext
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Bicycle> Bicycles { get; set; }
        protected override void onCongiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=apimasteryproject-bikes;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString)
            .UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>().HasData(

                );

            modelBuilder.Entity<Bicycle>().HasData(

                );
            base.OnModelCreating(modelBuilder);
        }

    }
}
