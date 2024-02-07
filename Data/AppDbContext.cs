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

            var random = new Random();

            var producers = new List<ProducerEntity>();
            for (int i = 1; i <= 5; i++)
            {
                producers.Add(new ProducerEntity
                {
                    Id = i,
                    Name = $"Producer{i}",
                    Description = $"Description for Producer{i}"
                });
            }

            var products = new List<ProductEntity>();
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

            modelBuilder.Entity<ProducerEntity>().HasData(producers);
            modelBuilder.Entity<ProductEntity>().HasData(products);
        }
    }
}