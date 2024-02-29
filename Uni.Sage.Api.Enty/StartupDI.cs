using Microsoft.Extensions.DependencyInjection;
using Uni.Sage.Api.Enty.Services;
using Uni.Sage.Infrastructures.Services;

namespace Uni.Sage.Api.Enty
{
    public partial class Startup
    {
        public void ConfigureDependencies(IServiceCollection services)
        {
            services.AddSingleton<IConnexionService, ConnexionService>();

            services.AddScoped<IQueryService, QueryService>();
            services.AddScoped<IArticleService, ArticleService>();
          
            services.AddScoped<IVenteService, VenteService>(); 
        }
   }
}   