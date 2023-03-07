using Joylet.API.Domain.Models;
using Joylet.API.Domain.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joylet.API.Domain.IServices
{
    public interface ICartService
    {
        
        Task<IEnumerable<dynamic>> AddCartsAsync(IEnumerable<CreateCartDto> cart);
        Task<IEnumerable<Cart>> GetCartsAsync();
        Task<Cart> GetCartByIdAsync(int id);
        Task<IEnumerable<dynamic>> GetCartsQuantityPriceAsync(int? id);
        IEnumerable<ResultCartDto> CalculateItemsCartById(IEnumerable<dynamic> cartsQuantityPriceResult);
        Task<bool> CartExists(IEnumerable<CreateCartDto> carts);
        Task<IEnumerable<DeliveryFee>> GetDeliveryFees();
        IEnumerable<ResultCartDto> CalculateDeliveryFee(IEnumerable<ResultCartDto> cartTotalResult, IEnumerable<DeliveryFee> deliveryFees);

    }
}
