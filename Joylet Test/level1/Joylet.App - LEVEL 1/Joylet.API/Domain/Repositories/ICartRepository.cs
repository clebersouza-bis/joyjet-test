using Joylet.API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joylet.API.Domain.Repositories
{
    public interface ICartRepository
    {
        Task<IEnumerable<Cart>> GetCartsAsync();
        Task<Cart> GetCartByIdAsync(int id);
        Task<IEnumerable<dynamic>> GetCartsQuantityPriceAsync(int? id);


    }
}
