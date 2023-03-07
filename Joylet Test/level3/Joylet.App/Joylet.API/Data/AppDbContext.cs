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
        public DbSet<Discount> Discounts { get; set; }

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
                    new Article { Id = 5, Name = "ketchup", Price = 999 },
                    new Article { Id = 6, Name = "mayonnaise", Price = 999 },
                    new Article { Id = 7, Name = "fries", Price = 378 },
                    new Article { Id = 8, Name = "ham", Price = 147 }
                );

            modelBuilder.Entity<CartItem>()
                .HasData(
                    new CartItem { CartId = 1, ArticleId = 1, Quantity = 6 },
                    new CartItem { CartId = 1, ArticleId = 2, Quantity = 2 },
                    new CartItem { CartId = 1, ArticleId = 4, Quantity = 1 },

                    new CartItem { CartId = 2, ArticleId = 2, Quantity = 1 },
                    new CartItem { CartId = 2, ArticleId = 3, Quantity = 3 },

                    new CartItem { CartId = 3, ArticleId = 5, Quantity = 1 },
                    new CartItem { CartId = 3, ArticleId = 6, Quantity = 1 },

                    new CartItem { CartId = 4, ArticleId = 7, Quantity = 1 },

                    new CartItem { CartId = 5, ArticleId = 8, Quantity = 3 }
                );

            modelBuilder.Entity<Discount>()
                .HasData(
                  new Discount { Id = 1, ArticleId = 2, Type = "amount", Value = 25, IsActive = true, IsExpired = false },
                  new Discount { Id = 2, ArticleId = 5, Type = "percentage", Value = 30, IsActive = true, IsExpired = false },
                  new Discount { Id = 3, ArticleId = 6, Type = "percentage", Value = 30, IsActive = true, IsExpired = false },
                  new Discount { Id = 4, ArticleId = 7, Type = "percentage", Value = 25, IsActive = true, IsExpired = false },
                  new Discount { Id = 5, ArticleId = 8, Type = "percentage", Value = 10, IsActive = true, IsExpired = false }
      );

            modelBuilder.Entity<CartItem>()
                .HasKey(CI => new { CI.ArticleId, CI.CartId });
        }

    }
}
