using Joylet.API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joylet.API.Domain.IServices
{
    public interface IArticleService
    {
        Task<IEnumerable<Article>> GetArticlesAsync();

    }
}
