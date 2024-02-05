using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
        public class AppDbContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProducerEntity> Producers { get; set; }
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "products.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity()
                {
                    Id = 1,
                    Name = "Product 1",
                    Price = 10.99m,
                    Producer = "Producer 1",
                    ProductionDate = new DateTime(2020, 10, 10),
                    Description = "Product 1 description",
                },
                new ProductEntity()
                {
                    Id = 2,
                    Name = "Product 2",
                    Price = 20.99m,
                    Producer = "Producer 2",
                    ProductionDate = new DateTime(2023, 10, 10),
                    Description = "Product 2 description",
                }
            );

            modelBuilder.Entity<ProducerEntity>().HasData(
               new ProducerEntity()
               {
                   Id = 1,
                   Name = "Przemo",
                   Description = "Robi muze",
               },
               new ProducerEntity()
               {
                   Id = 2,
                   Name = "Kacpi",
                   Description = "Robi halas",
               }
           );
        }
    }
}