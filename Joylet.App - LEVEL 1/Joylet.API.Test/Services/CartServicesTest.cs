using AutoMapper;
using Joylet.API.Data;
using Joylet.API.Data.Repositories;
using Joylet.API.Domain.IServices;
using Joylet.API.Domain.Models;
using Joylet.API.Domain.Models.Dto;
using Joylet.API.Domain.Repositories;
using Joylet.API.Mapping;
using Joylet.API.Test.Data;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Joylet.API.Test.Services
{
    public class CartServicesTest
    {
        [Theory]
        [ClassData(typeof(CartTestData))]
        public async Task Test_CreateCarts_TryExistentCart_Exception(IEnumerable<CreateCartDto> createCartDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
            var context = new AppDbContext(options);
            AppDbContext resultContext = await SeedData(context, mapper);

            var cartRepository = new CartRepository(context);
            var cartService = new CartService(cartRepository, new Mock<IUnitOfWork>().Object, mapper);
            await context.SaveChangesAsync();

            await Assert.ThrowsAsync<Exception>(async () => await cartService.CartExists(createCartDto));
        }

        [Fact]
        private async void Test_GetCartsQuantityAndPrice_All_NotNull()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
            var context = new AppDbContext(options);
            AppDbContext resultContext = await SeedData(context, mapper);

            var cartRepository = new CartRepository(context);
            var cartService = new CartService(cartRepository, new Mock<IUnitOfWork>().Object, mapper);
            await context.SaveChangesAsync();

            int? id = 0;
            var quantityPriceResult = await cartService.GetCartsQuantityPriceAsync(id);
            Assert.NotNull(quantityPriceResult);
        }


        [Theory]
        [InlineData(1)]
        private async void Test_GetCartsQuantityAndPrice_ById_NotNull(int id)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
            var context = new AppDbContext(options);
            AppDbContext resultContext = await SeedData(context, mapper);

            var cartRepository = new CartRepository(context);
            var cartService = new CartService(cartRepository, new Mock<IUnitOfWork>().Object, mapper);
            await context.SaveChangesAsync();

            var quantityPriceResult = await cartService.GetCartsQuantityPriceAsync(id);
            Assert.NotNull(quantityPriceResult);
        }

        [Fact]
        private async void Test_CalculatedItemsCart_All_ListCarts()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
            var context = new AppDbContext(options);
            AppDbContext resultContext = await SeedData(context, mapper);

            var cartRepository = new CartRepository(context);
            var cartService = new CartService(cartRepository, new Mock<IUnitOfWork>().Object, mapper);
            await context.SaveChangesAsync();

            int? id = 0;
            var quantityPrice = await cartService.GetCartsQuantityPriceAsync(id);
            var resultCalculateCart = cartService.CalculateItemsCartById(quantityPrice);
            Assert.IsType<List<ResultCartDto>>(resultCalculateCart);
        }

        [Theory]
        [InlineData(1)]
        private async void Test_CalculatedItemsCart_ById_NotNull(int id)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
            var context = new AppDbContext(options);
            AppDbContext resultContext = await SeedData(context, mapper);

            var cartRepository = new CartRepository(context);
            var cartService = new CartService(cartRepository, new Mock<IUnitOfWork>().Object, mapper);
            await context.SaveChangesAsync();
            var quantityPrice = await cartService.GetCartsQuantityPriceAsync(id);
            var resultCalculateCart = cartService.CalculateItemsCartById(quantityPrice);
            var result = resultCalculateCart.Select(t => new
            {
                total = t.Total
            });
            var finalResult = result.ElementAt(0).total;
            Assert.Equal(2000, finalResult);
        }

        private async Task<AppDbContext> SeedData(AppDbContext context, IMapper mapper)
        {
            await context.Articles.AddAsync(new Article { Id = 1, Name = "water", Price = 100 });
            await context.Articles.AddAsync(new Article { Id = 2, Name = "honey", Price = 200 });
            await context.Articles.AddAsync(new Article { Id = 3, Name = "mango", Price = 400 });
            await context.Articles.AddAsync(new Article { Id = 4, Name = "tea", Price = 1000 });

            await context.Carts.AddAsync(new Cart
            {
                Id = 1,
                CartDetails = "test 2",
                CartsItems = new List<CartItem> { new CartItem { Quantity = 6, ArticleId = 1 },
                                                  new CartItem { Quantity = 2, ArticleId = 2 },
                                                  new CartItem { Quantity = 1, ArticleId = 4 }
                },
            });

            await context.Carts.AddAsync(new Cart
            {
                Id = 2,
                CartDetails = "test",
                CartsItems = new List<CartItem> { new CartItem { Quantity = 1, ArticleId = 2 },
                                                  new CartItem { Quantity = 3, ArticleId = 3 }
                },
            });

            return context;
        }
    }
}
