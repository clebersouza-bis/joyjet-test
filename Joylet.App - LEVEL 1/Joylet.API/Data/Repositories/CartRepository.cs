using Joylet.API.Domain.Models;
using Joylet.API.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joylet.API.Data.Repositories
{
    public class CartRepository : BaseRepository, ICartRepository
    {
        public CartRepository(AppDbContext context) : base(context)
        {
        }
         public async Task<IEnumerable<Cart>> GetCartsAsync()
        {
            return await _context.Carts
                .Include(c => c.CartsItems)
                .ThenInclude(a => ((CartItem)a).Articles)
                .ToListAsync();
        }

        public async Task<Cart> GetCartByIdAsync(int id)
        {
            return await _context.Carts
                .Include(c => c.CartsItems)
                .ThenInclude(a => ((CartItem)a).Articles)
                .Where(c => c.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<dynamic>> GetCartsQuantityPriceAsync(int? id)
        {
            IQueryable<Cart> carts;
            if (id > 0)
            {
                carts = _context.Carts.AsQueryable().Where(x => x.Id == id);
            }
            else
            {
                carts =  _context.Carts.AsQueryable();
            }

            var cartsQuantityPriceResult = await(from c in carts
                                                 join ci in _context.CartsItems
                                                 on c.Id equals ci.CartId
                                                 into ResultSet
                                                 from cartResult in ResultSet.DefaultIfEmpty()
                                                 join a in _context.Articles
                                                 on cartResult.ArticleId equals a.Id
                                                 into ResultSet2
                                                 from articleResult in ResultSet2.DefaultIfEmpty()
                                                 select new 
                                                 {
                                                     cartId = c.Id,
                                                     articleId = cartResult == null ? 0 : cartResult.ArticleId,
                                                     quantity = cartResult == null ? 0 : cartResult.Quantity,
                                                     price = articleResult == null ? 0 : articleResult.Price
                                                 }
                                                 ).ToListAsync();
            return cartsQuantityPriceResult;
        }

    }
}
