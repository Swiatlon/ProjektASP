using Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProducerEntity> Producers { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "messi.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string ADMIN_ID = Guid.NewGuid().ToString();
            string USER_ID = Guid.NewGuid().ToString();

            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "admin",
                NormalizedName = "admin",
                Id = ADMIN_ROLE_ID,
                ConcurrencyStamp = ADMIN_ROLE_ID
            });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "user",
                NormalizedName = "user",
                Id = USER_ROLE_ID,
                ConcurrencyStamp = USER_ROLE_ID
            });

            var admin = new IdentityUser
            {
                Id = ADMIN_ID,
                Email = "admin@wsei.edu.pl",
                EmailConfirmed = true,
                UserName = "admin",
                NormalizedUserName = "admin",
                NormalizedEmail = "ADMIN@WSEI.EDU.PL"
            };

            var user = new IdentityUser
            {
                Id = USER_ID,
                Email = "user@wsei.edu.pl",
                EmailConfirmed = true,
                UserName = "user",
                NormalizedUserName = "user",
                NormalizedEmail = "USER@WSEI.EDU.PL"
            };

            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = ph.HashPassword(admin, "ADMIN123!");
            user.PasswordHash = ph.HashPassword(user, "USER123!");

            modelBuilder.Entity<IdentityUser>().HasData(admin);
            modelBuilder.Entity<IdentityUser>().HasData(user);
            modelBuilder.Entity<IdentityUserRole<string>>()
            .HasData(new IdentityUserRole<string>
            {
                RoleId = ADMIN_ROLE_ID,
                UserId = ADMIN_ID
            }, new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_ID,
                UserId = USER_ID
            }
            );

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