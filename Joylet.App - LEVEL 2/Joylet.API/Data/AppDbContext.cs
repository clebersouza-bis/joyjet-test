using Joylet.API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Joylet.API.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<CartItem> CartsItems { get; set; }
        public DbSet<DeliveryFee> DeliveryFees { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .Property(p => p.Price)
                .IsRequired(true);

            modelBuilder.Entity<Article>()
                .Property(p => p.Name)
                .IsRequired(true)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Cart>()
                .Property(p => p.CartDetails)
                .IsRequired(false);

            modelBuilder.Entity<Article>()
                .HasData(
                    new Article { Id = 1, Name = "water", Price = 100 },
                    new Article { Id = 2, Name = "honey", Price = 200 },
                    new Article { Id = 3, Name = "mango", Price = 400 },
                    new Article { Id = 4, Name = "tea", Price = 1000 }
                );
            modelBuilder.Entity<Cart>()
                .HasData(
                    new Cart { Id = 1, CartDetails = "Details 1" },
                    new Cart { Id = 2, CartDetails = "Details 2" },
                    new Cart { Id = 3, CartDetails = "Details 3" }
                );
            modelBuilder.Entity<CartItem>()
                .HasData(
                    new CartItem { CartId = 1, ArticleId = 1, Quantity = 6 },
                    new CartItem { CartId = 1, ArticleId = 2, Quantity = 2 },
                    new CartItem { CartId = 1, ArticleId = 4, Quantity = 1 },

                    new CartItem { CartId = 2, ArticleId = 2, Quantity = 1 },
                    new CartItem { CartId = 2, ArticleId = 3, Quantity = 3 }
                );

            modelBuilder.Entity<DeliveryFee>()
                .HasData(
                    new DeliveryFee { Id = 1, MinPrice = 0, MaxPrice = 1000, DeliveryPrice = 800, IsActive = true, IsExpired = false },
                    new DeliveryFee { Id = 2, MinPrice = 1000, MaxPrice = 2000, DeliveryPrice = 400, IsActive = true, IsExpired = false },
                    new DeliveryFee { Id = 3, MinPrice = 2000, MaxPrice = null, DeliveryPrice = 0, IsActive = true, IsExpired = false }
                );

            modelBuilder.Entity<CartItem>()
                .HasKey(CI => new { CI.ArticleId, CI.CartId });
        }

    }
}
