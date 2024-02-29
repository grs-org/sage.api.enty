using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Collections.Generic;
using System.Threading.Tasks;
using Uni.Sage.Api.Enty.Services;
using Uni.Sage.Shared.Wrapper;

namespace Uni.Sage.Api.Enty.Controllers
{
    public class ArticleController : BaseController
    {
        private readonly IArticleService _ArticleService;

        public ArticleController(IArticleService articleService) : base()
        {

            _ArticleService = articleService;

        }


        [HttpGet(nameof(GetArticles))]
        public async Task<ActionResult> GetArticles(string pConnexionName)
        {
            var result = await _ArticleService.GetArticles(pConnexionName);
            return Ok(result);
        }

       

       
    }
}
