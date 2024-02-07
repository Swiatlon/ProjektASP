using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
        public class AppDbContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProducerEntity> Producers { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "projekt.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>()
                .HasOne(p => p.Producer)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.ProducerId);

            modelBuilder.Entity<ProducerEntity>()
               .HasOne(p => p.Address)
               .WithMany()
               .HasForeignKey(p => p.AddressId);

            var random = new Random();
            var producers = new List<ProducerEntity>();

            for (int i = 1; i <= 10; i++)
            {
                producers.Add(new ProducerEntity
                {
                    Id = i,
                    Name = $"Producer{i}",
                    Description = $"Description for Producer{i}",
                    AddressId = i
                });
            }

            var products = new List<ProductEntity>();
            var addresses = new List<AddressEntity>();

            for (int i = 1; i <= 10; i++)
            {
                var producerId = random.Next(1, 6);
                products.Add(new ProductEntity
                {
                    Id = i,
                    Name = $"Product{i}",
                    Price = (decimal)random.NextDouble() * 100,
                    ProducerId = producerId,
                    ProductionDate = DateTime.Now.AddDays(-random.Next(1, 365)),
                    Description = $"Description for Product{i}"
                });
            }

            for (int i = 1; i <= 10; i++)
            {
                addresses.Add(new AddressEntity
                {
                    Id = i,
                    City = $"City{i}",
                    Street = $"Street{i}",
                    PostalCode = $"{i}00-000",
                    Region = $"Region{i}"
                });
            }

            modelBuilder.Entity<AddressEntity>().HasData(addresses);
            modelBuilder.Entity<ProducerEntity>().HasData(producers);
            modelBuilder.Entity<ProductEntity>().HasData(products);
        }
    }
}