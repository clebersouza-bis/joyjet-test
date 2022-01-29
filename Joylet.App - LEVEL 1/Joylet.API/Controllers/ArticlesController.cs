using Joylet.API.Domain.IServices;
using Joylet.API.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joylet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public async Task<IEnumerable<Article>> GetArticlesAsync()
        {
            var result = await _articleService.GetArticlesAsync();
            return result;
        }

    }
}
