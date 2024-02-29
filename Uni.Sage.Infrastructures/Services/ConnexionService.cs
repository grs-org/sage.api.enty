using Serilog;
using System.Data;
using System.Reflection;
using System.Text.Json;
using Uni.Sage.Shared.Wrapper;

namespace Uni.Sage.Api.Enty.Services
{
    public interface IConnexionService
    {
        List<SageConnexion> SageConnexions { get; set; }

        void Load();

        Task<IResult<List<SageConnexion>>> GetPublicConnections();

        string GetQuery(string pName, SageConnexion sageConnexion);

        List<string> ReadResourceListe();
    }

    public class ConnexionService : IConnexionService
    {
        private const string appCompaniesPath = @"\appconnexions.json";
        private List<SageQuery> _ListQueries;
        private List<SageConnexion> _connexions;

        public ConnexionService()
        {
            Load();
        }

        public void Load()
        {
            if (_connexions != null) return;

            Log.Information("## Loading connexions ");
            var fullpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + appCompaniesPath;
            if (System.IO.File.Exists(fullpath))
            {
                var jsonString = File.ReadAllText(fullpath);

                _connexions = JsonSerializer.Deserialize<List<SageConnexion>>(jsonString);
                
                Log.Information("## Loading connexions done ");

                Log.Debug("##  Loading Queries");

                _ListQueries = new List<SageQuery>();
                var olistResources = ReadResourceListe();
                foreach (var resource in olistResources)
                {
                    var oparts = resource.Split(".");

                    var oSqlQuery = new SageQuery()
                    {
                        Path = resource,
                        Version = oparts[0],
                        Domain = oparts[1],
                        Name = oparts[2].ToUpper()
                    };
                    oSqlQuery.Query = ReadResource(oSqlQuery.Path);

                    _ListQueries.Add(oSqlQuery);
                }

                Log.Debug("##  Loading Queries Done");
            }
            else
            {
                _connexions = new List<SageConnexion>();
                Log.Fatal($"Companies file not found in : {fullpath}");
            }
        }

        public async Task<IResult<List<SageConnexion>>> GetPublicConnections()
        {
            return await Result<List<SageConnexion>>.SuccessAsync(SageConnexions.Select(o => new SageConnexion { Name = o.Name, Version = o.Version, ConnectionString = "***************" }).ToList());
        }

        public List<SageConnexion> SageConnexions
        {
            get
            {
                Load();
                return _connexions;
            }
            set
            {
                var jsonString = JsonSerializer.Serialize(value);
                File.WriteAllText(appCompaniesPath, jsonString);
                _connexions = value;
            }
        }

        public string ReadResource(string path)
        {
            // Determine path
            var assembly = Assembly.GetExecutingAssembly();
            string resourcePath = path;
            // Format: "{Namespace}.{Folder}.{filename}.{Extension}"
            if (!path.StartsWith("Uni.Sage."))
            {
                resourcePath = assembly.GetManifestResourceNames()
                    .Single(str => str.EndsWith(path));
            }

            using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public List<string> ReadResourceListe()
        {
            // Determine path

            var assembly = Assembly.GetExecutingAssembly();
            //var lisResources = assembly.GetManifestResourceNames();

            return assembly.GetManifestResourceNames().Where(o => o.Contains("Sage100") && o.EndsWith(".Sql")).Select(o => o.Substring(o.IndexOf("Sage100"))).ToList();
        }

        public string GetQuery(string pName, SageConnexion pSageConnexion)
        {
            var oSageQuery = _ListQueries.Where(o => o.Version == pSageConnexion.Version && o.Name == pName).FirstOrDefault();
            if (oSageQuery == null) oSageQuery = _ListQueries.Where(o => o.Version == "Sage100" && o.Name == pName).FirstOrDefault();
            return oSageQuery.Query;
        }
    }

    public class SageConnexion
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string ConnectionString { get; set; }
    }

    public class SageQuery
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Query { get; set; }
        public string Path { get; set; }
        public string Domain { get; set; }
    }
}
