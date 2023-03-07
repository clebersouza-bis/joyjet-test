using Joylet.API.Domain.Models;
using Joylet.API.Domain.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Joylet.API.Domain.Models.Dto;
using System;

namespace Joylet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartsController : ControllerBase
    {
        private readonly ICartService _cartService;     
        public CartsController(ICartService cartService)
        {
            _cartService = cartService;
            _cartService.re
        }

        [HttpPost]
        public async Task<IEnumerable<ResultCartDto>> CreateCartAsync([FromBody] IEnumerable<CreateCartDto> carts)
        {
            var cartExist = await _cartService.CartExists(carts);
            if (cartExist)
            {
                throw new Exception("This cart already Exist. Let this field as 0");                
            }

            var result = await _cartService.AddCartsAsync(carts);
            var cartCalculationResult = _cartService.CalculateItemsCartById(result);
            return cartCalculationResult;
        }

        [HttpGet]
        public async Task<IEnumerable<Cart>> GetCartsAsync()
        {
            var carts = await _cartService.GetCartsAsync();
            return carts;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Cart> GetCartByIdAsync(int id)
        {           
            var carts = await _cartService.GetCartByIdAsync(id);
            return carts;
        }

        [HttpGet]
        [Route("getcartsresult")]
        public async Task<IEnumerable<ResultCartDto>> GetCartsResultAsync(int? id)
        {
            var cartsQuantityPriceResult = await _cartService.GetCartsQuantityPriceAsync(id);
            var cartsQuantityPriceDiscountResult = _cartService.GetCartsQuantityPriceWithDiscountAsync(cartsQuantityPriceResult);
            var cartsTotalResultWithDiscount = _cartService.CalculateItemsWithDiscountCartById(cartsQuantityPriceDiscountResult);
            var cartsTotalResult = _cartService.CalculateItemsCartById(cartsTotalResultWithDiscount);
            var deliveryFees = await _cartService.GetDeliveryFees();
            var cartsTotalResultWithShip = _cartService.CalculateDeliveryFee(cartsTotalResult, deliveryFees);
            return cartsTotalResultWithShip;
        }

    }
}
