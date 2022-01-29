using Joylet.API.Domain.Models;
using Joylet.API.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joylet.API.Data.Repositories
{
    public class ArticleRepository : BaseRepository, IArticleRepository
    {
        public ArticleRepository(AppDbContext context) : base(context)
        {
        }       
        public async Task<IEnumerable<Article>> GetArticlesAsync()
        {
            return await _context.Articles.ToListAsync();
        }
    }
}
