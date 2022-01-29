﻿// <auto-generated />
using System;
using Joylet.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Joylet.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220123185516_LevelTwoFeesAndDiscount")]
    partial class LevelTwoFeesAndDiscount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Joylet.API.Domain.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasPrecision(10, 2)
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "water",
                            Price = 100m
                        },
                        new
                        {
                            Id = 2,
                            Name = "honey",
                            Price = 200m
                        },
                        new
                        {
                            Id = 3,
                            Name = "mango",
                            Price = 400m
                        },
                        new
                        {
                            Id = 4,
                            Name = "tea",
                            Price = 1000m
                        });
                });

            modelBuilder.Entity("Joylet.API.Domain.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CartDetails")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("DeliveryFeesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryFeesId");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CartDetails = "Details 1"
                        },
                        new
                        {
                            Id = 2,
                            CartDetails = "Details 2"
                        },
                        new
                        {
                            Id = 3,
                            CartDetails = "Details 3"
                        });
                });

            modelBuilder.Entity("Joylet.API.Domain.Models.CartItem", b =>
                {
                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ArticleId", "CartId");

                    b.HasIndex("CartId");

                    b.ToTable("CartsItems");

                    b.HasData(
                        new
                        {
                            ArticleId = 1,
                            CartId = 1,
                            Quantity = 6
                        },
                        new
                        {
                            ArticleId = 2,
                            CartId = 1,
                            Quantity = 2
                        },
                        new
                        {
                            ArticleId = 4,
                            CartId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            ArticleId = 2,
                            CartId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            ArticleId = 3,
                            CartId = 2,
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("Joylet.API.Domain.Models.DeliveryFee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("DeliveryPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsExpired")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal?>("MaxPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("MinPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("DeliveryFees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeliveryPrice = 800m,
                            IsActive = true,
                            IsExpired = false,
                            MaxPrice = 1000m,
                            MinPrice = 0m
                        },
                        new
                        {
                            Id = 2,
                            DeliveryPrice = 400m,
                            IsActive = true,
                            IsExpired = false,
                            MaxPrice = 2000m,
                            MinPrice = 1000m
                        },
                        new
                        {
                            Id = 3,
                            DeliveryPrice = 0m,
                            IsActive = true,
                            IsExpired = false,
                            MinPrice = 4000m
                        });
                });

            modelBuilder.Entity("Joylet.API.Domain.Models.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsExpired")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Discounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = 2,
                            IsActive = true,
                            IsExpired = false,
                            Type = "amount",
                            Value = 25m
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = 5,
                            IsActive = true,
                            IsExpired = false,
                            Type = "percentage",
                            Value = 30m
                        },
                        new
                        {
                            Id = 3,
                            ArticleId = 6,
                            IsActive = true,
                            IsExpired = false,
                            Type = "percentage",
                            Value = 30m
                        },
                        new
                        {
                            Id = 4,
                            ArticleId = 7,
                            IsActive = true,
                            IsExpired = false,
                            Type = "percentage",
                            Value = 25m
                        },
                        new
                        {
                            Id = 5,
                            ArticleId = 8,
                            IsActive = true,
                            IsExpired = false,
                            Type = "percentage",
                            Value = 10m
                        });
                });

            modelBuilder.Entity("Joylet.API.Domain.Models.Cart", b =>
                {
                    b.HasOne("Joylet.API.Domain.Models.DeliveryFee", "DeliveryFees")
                        .WithMany()
                        .HasForeignKey("DeliveryFeesId");

                    b.Navigation("DeliveryFees");
                });

            modelBuilder.Entity("Joylet.API.Domain.Models.CartItem", b =>
                {
                    b.HasOne("Joylet.API.Domain.Models.Article", "Articles")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Joylet.API.Domain.Models.Cart", "Carts")
                        .WithMany("CartsItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Articles");

                    b.Navigation("Carts");
                });

            modelBuilder.Entity("Joylet.API.Domain.Models.Discount", b =>
                {
                    b.HasOne("Joylet.API.Domain.Models.Article", "Articles")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Joylet.API.Domain.Models.Cart", b =>
                {
                    b.Navigation("CartsItems");
                });
#pragma warning restore 612, 618
        }
    }
}
