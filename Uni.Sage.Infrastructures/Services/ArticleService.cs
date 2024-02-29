
using Dapper;
using Serilog;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uni.Sage.Domain.Entities;
using Uni.Sage.Shared.Wrapper;

namespace Uni.Sage.Api.Enty.Services
{
    public interface IArticleService
    {
        Task<IResult<List<ArticleResponse>>> GetArticles(string pConnexionName);
        Task<IResult<List<ArticleParDepotResponse>>> GetArticlesParDepot(string pConnexionName);
    }

    public class ArticleService : IArticleService
    {
         
        private readonly IQueryService _QueryService;

        public ArticleService(IQueryService queryService)
        {
            
            _QueryService = queryService;
        }

        public async Task<IResult<List<ArticleResponse>>> GetArticles(string pConnexionName)
        {
             
            try
            {
                using var db = _QueryService.NewDbConnection(pConnexionName);
                var oQuery = _QueryService.GetQuery("SELECT_ARTICLE_MIN");

                var results = await db.QueryAsync<ArticleResponse>(oQuery);

                return await Result<List<ArticleResponse>>.SuccessAsync(results.ToList());
            }
            catch (System.Exception ex)
            {
                Log.Fatal(ex," Get Articles societe {0}  error : {1}",pConnexionName,ex.ToString());
                return await Result<List<ArticleResponse>>.FailAsync(ex);
            }

        }
        public async Task<IResult<List<ArticleParDepotResponse>>> GetArticlesParDepot(string pConnexionName)
        {
           
            try
            {

              

                using var db = _QueryService.NewDbConnection(pConnexionName);
                var oQuery = _QueryService.GetQuery("SELECT_ARTICLE_PAR_DEPOT");
                var results = await db.QueryAsync<ArticleParDepotResponse>(oQuery);

                return await Result<List<ArticleParDepotResponse>>.SuccessAsync(results.ToList());
            }
            catch (System.Exception ex)
            {
                Log.Fatal(ex, " Get Articles societe {0}  error : {1}", pConnexionName, ex.ToString());
                return await Result<List<ArticleParDepotResponse>>.FailAsync(ex);
            }

        }
    }


}
