﻿using AutoMapper;
using Joylet.API.Domain.Models;
using Joylet.API.Domain.Models.Dto;
using Joylet.API.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joylet.API.Domain.IServices
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CartService(ICartRepository cartRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _cartRepository = cartRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<dynamic>> AddCartsAsync(IEnumerable<CreateCartDto> cart)
        {
            try
            {
                var mappedCart = _mapper.Map<IEnumerable<CreateCartDto>, IEnumerable<Cart>>(cart);
                await _unitOfWork.AddRange<Cart>(mappedCart);
                if (await _unitOfWork.SaveChangesAsync())
                {
                    int? id = 0;
                    return await _cartRepository.GetCartsQuantityPriceAsync(id);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<Cart>> GetCartsAsync()
        {
            return await _cartRepository.GetCartsAsync();
        }

        public async Task<Cart> GetCartByIdAsync(int id)
        {
            return await _cartRepository.GetCartByIdAsync(id);        }

        public async Task<IEnumerable<dynamic>> GetCartsQuantityPriceAsync(int? id)
        {
            return await _cartRepository.GetCartsQuantityPriceAsync(id);
        }

        public IEnumerable<ResultCartDto> CalculateItemsCartById(IEnumerable<dynamic> cartsQuantityPriceResult)
        {

            var totalCart = (from cart in cartsQuantityPriceResult
                             group cart by cart.cartId into cartGroup
                             select new
                             {
                                 id = cartGroup.Key,
                                 total = cartGroup.Sum(x => (int)x.quantity * (int)x.price)
                             }).ToList();

            var cartDtoResult = totalCart.Select(g => new ResultCartDto()
            {
                Id = g.id,
                Total = g.total
            }).OrderBy(c => c.Id).ToList();

            return cartDtoResult;
        }

        public IEnumerable<dynamic> CalculateItemsWithDiscountCartById(IEnumerable<dynamic> cartsQuantityPriceResult)
        {

            var query = cartsQuantityPriceResult.Select(c => c.cartId);

            var test2 = query.Where(c => c.cartId > 0);

            var resultNewPricesDiscountCart = new List<dynamic>();
            foreach (var item in cartsQuantityPriceResult)
            {
                var test = cartsQuantityPriceResult.FirstOrDefault();
                var t = test.quantity;
                var cartId = item.cartId;
                var quantity = item.quantity;
                var price = item.price;
                var discount = item.discount;
                string discountType = item.discountType;
                var newPrice = GetPriceByTypeOfDiscount(discountType, discount, price);
                var totalItem = quantity * newPrice;
                resultNewPricesDiscountCart.Add(new { cartId = cartId, quantity = quantity, price = newPrice });
            }

            return resultNewPricesDiscountCart;
        }

        public dynamic GetPriceByTypeOfDiscount(string typeOdDiscount, decimal discount, decimal price)
        {
            switch (typeOdDiscount)
            {
                case "amount": 
                    price = price - discount;
                    break;
                case "percentage":
                    discount = discount == null ? 0 : discount;
                    price = price * (1 - (discount / 100));
                    break;
                default:
                    break;
            }

            return price;
        }

        public async Task<bool> CartExists(IEnumerable<CreateCartDto> carts)
        {

            foreach (var cart in carts)
            {
                var cartId = cart.Id;
                if (cartId == 0) continue;
                var cartExists = await _cartRepository.GetCartByIdAsync(cartId);
                if (cartExists != null)
                {
                    throw new Exception("This cart Id already exists. We recommend let this field as 0");
                }
            }
            return false;
        }

        public async Task<IEnumerable<DeliveryFee>> GetDeliveryFees()
        {
            return await _cartRepository.GetDeliveryFees();
        }

        public IEnumerable<ResultCartDto> CalculateDeliveryFee(IEnumerable<ResultCartDto> cartTotalResult, IEnumerable<DeliveryFee> deliveryFees)
        {
            foreach (var item in cartTotalResult)
            {
                var totalCart = item.Total;
                var fee = deliveryFees
                    .Where(c => c.MinPrice <= totalCart && c.MaxPrice >= totalCart)
                    .FirstOrDefault();
                item.Total = item.Total + fee.DeliveryPrice;
            }

            return cartTotalResult;
        }

        public IEnumerable<dynamic> GetCartsQuantityPriceWithDiscountAsync(IEnumerable<dynamic> cartsQuantityPriceResult)
        {
            var result = _cartRepository.GetCartsQuantityPriceWithDiscountAsync(cartsQuantityPriceResult);
            return result;
        }
    }
}
