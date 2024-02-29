
using Dapper;
using Serilog;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uni.Sage.Api.Enty.Model;
using Uni.Sage.Domain.Entities;
using Uni.Sage.Shared.Wrapper;

namespace Uni.Sage.Api.Enty.Services
{
    public interface IArticleService
    {
        Task<IResult<List<ArticleParPrixResponse>>> GetArticles(string pConnexionName);
    }

    public class ArticleService : IArticleService
    {
         
        private readonly IQueryService _QueryService;

        public ArticleService(IQueryService queryService)
        {
            
            _QueryService = queryService;
        }

        public async Task<IResult<List<ArticleParPrixResponse>>> GetArticles(string pConnexionName)
        {
             
            try
            {
                var CodeCatTarif = 2;
                using var db = _QueryService.NewDbConnection(pConnexionName);
                var oQuery = _QueryService.GetQuery("SELECT_ARTICLE_MIN");

                var results = await db.QueryAsync<ArticleResponse>(oQuery);

                var oQueryCatTarif = _QueryService.GetQuery("SELECT_TARIFCLIENT");
                var resultsCatTarif = await db.QueryAsync<TarifClientResponse>(oQueryCatTarif);


                List<ArticleParPrixResponse> Article = new List<ArticleParPrixResponse>();

                foreach (var item in results)
                {
                    var CatTarif = resultsCatTarif.FirstOrDefault(x => x.Reference == item.Reference && x.CodeCategorie == CodeCatTarif);
                    if (CatTarif == null)
                    {
                        Article.Add(new ArticleParPrixResponse
                        {
                            Reference = item.Reference,
                            CodeFamille = item.CodeFamille,
                            Designation = item.Designation,
                            Famille = item.Famille,
                            PrixVente = item.PrixVente,
                        });
                    }
                    else{

                        Article.Add(new ArticleParPrixResponse
                        {
                            Reference = item.Reference,
                            CodeFamille = item.CodeFamille,
                            Designation = item.Designation,
                            Famille = item.Famille,
                            PrixVente = CatTarif.PrixVente,
                        });
                    }
                }

                return await Result<List<ArticleParPrixResponse>>.SuccessAsync(Article.ToList());
            }
            catch (System.Exception ex)
            {
                Log.Fatal(ex," Get Articles societe {0}  error : {1}",pConnexionName,ex.ToString());
                return await Result<List<ArticleParPrixResponse>>.FailAsync(ex);
            }

        }
      
    }


}
