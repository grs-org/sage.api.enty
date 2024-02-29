using System.Data;
using System.Data.SqlClient;
using Uni.Sage.Infrastructures.Repositories;

namespace Uni.Sage.Api.Enty.Services
{
    public interface IQueryService
    {
        string SELECT_SOUCHE_BY_ID { get { return GetQuery("SELECT_SOUCHE_BY_ID"); } }

        string SELECT_ARTCILE_ISACTIF { get { return GetQuery("SELECT_ARTCILE_ISACTIF"); } }

        string SELECT_COLLABORATEUR_BY_ID { get { return GetQuery("SELECT_COLLABORATEUR_BY_ID"); } }

        string SELECT_DEPOT_BY_ID { get { return GetQuery("SELECT_DEPOT_BY_ID"); } }

        string SELECT_CATTARIF_BY_ID { get { return GetQuery("SELECT_CATTARIF_BY_ID"); } }

        IDbConnection NewDbConnection(string pConnexionName);

        SageRepository NewRepository(string pConnexionName);
        string GetQuery(string pName);

        
    }

    public class QueryService : IQueryService
    {
        //liste des version supportées : pour chaque version nous devrons avoir un fichier resx nomé Sage{version}.resx

        private readonly IConnexionService _ConnexionServices;

        public SageConnexion _SageConnexion { get; private set; }

        public QueryService(IConnexionService pConnexionService)
        {
            _ConnexionServices = pConnexionService;
        }

        public string GetQuery(string pName)
        {
            if (_SageConnexion == null)
            {
                throw new System.ApplicationException($" la connection n'est pas definie dans le service de requêtes ! ");
            }
            return _ConnexionServices.GetQuery(pName, _SageConnexion);
        }

        public IDbConnection NewDbConnection(string pConnexionName)
        {
            _SageConnexion = _ConnexionServices.SageConnexions.FirstOrDefault(x => x.Name == pConnexionName);
            if (_SageConnexion == null)
            {
                throw new System.ApplicationException($" la société [{pConnexionName }]   est introuvable ! ");
            }
            if (string.IsNullOrWhiteSpace(_SageConnexion.Version)) throw new Exception($"Connexion version not resolved");

            return new SqlConnection(_SageConnexion.ConnectionString);
        }

        public SageRepository NewRepository(string pConnexionName)
        {
            return new SageRepository(NewDbConnection(pConnexionName), this);
        }
    }
}