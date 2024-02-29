using Dapper;
using System.Data;
using Uni.Sage.Api.Enty.Services;

namespace Uni.Sage.Infrastructures.Repositories
{
    public class SageRepository : IDisposable
    {
        private bool disposedValue;
        private IDbTransaction transaction;

        public IDbConnection Db { get; private set; }
        public IQueryService QueryService { get; private set; }

        public SageRepository(IDbConnection db, IQueryService queryService)
        {
            Db = db;
            QueryService = queryService;
        }

        //public async Task<T> QuerySingleOrDefaultAsync<T>( string QueryName, object param = null)
        //{
        //    return await Db.QuerySingleOrDefaultAsync<T>(QueryService.GetQuery(QueryName), param);
        //}
        public async Task<T> QueryFirstOrDefaultAsync<T>(string QueryName, object param = null)
        {
            return await Db.QueryFirstOrDefaultAsync<T>(QueryService.GetQuery(QueryName), param, transaction);
        }

        public async Task<T> ExecuteScalarAsync<T>(string QueryName, object param = null)
        {
            return await Db.ExecuteScalarAsync<T>(QueryService.GetQuery(QueryName), param, transaction);
        }

         
        public  async Task<IEnumerable<T>> QueryAsync<T>( string QueryName, object param = null)
        {
            return await Db.QueryAsync<T>(QueryService.GetQuery(QueryName), param, transaction);
        }
        public async Task<int> ExecuteAsync( string QueryName, object param = null)
        {
            return await Db.ExecuteAsync(QueryService.GetQuery(QueryName), param, transaction);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue=true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~SageRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        internal IDbTransaction BeginTransaction()
        {
            if (transaction == null)
            {
                if (Db.State == ConnectionState.Closed || Db.State== ConnectionState.Broken) Db.Open();
                transaction = Db.BeginTransaction();
            }
            return transaction;
             
        }
    }
}