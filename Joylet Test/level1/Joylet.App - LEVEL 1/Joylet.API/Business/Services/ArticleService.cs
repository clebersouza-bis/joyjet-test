using Joylet.API.Domain.IServices;
using Joylet.API.Domain.Models;
using Joylet.API.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joylet.API.Business.Services
{
    public class ArticleService : IArticleService
    {
        public readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        public async Task<IEnumerable<Article>> GetArticlesAsync()
        {
            return await _articleRepository.GetArticlesAsync();
        }

    }
}
