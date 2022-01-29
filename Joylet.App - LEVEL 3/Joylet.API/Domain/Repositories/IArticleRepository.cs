using Joylet.API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joylet.API.Domain.Repositories
{
    public interface IArticleRepository
    {
        Task<IEnumerable<Article>> GetArticlesAsync();
    }
}
