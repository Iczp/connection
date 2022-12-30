using Microsoft.Extensions.Options;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using IczpNet.Connection.Options;
using IczpNet.Connection.ServerHosts;

namespace IczpNet.Connection.Connections
{
    public class ConnectionManager : DomainService, IConnectionManager
    {
        protected IRepository<Connection, string> Repository { get; }
        protected ConnectionOptions Config { get; }
        public ConnectionManager(
            IRepository<Connection, string> repository,
            IOptions<ConnectionOptions> options)
        {
            Repository = repository;
            Config = options.Value;
        }

        public virtual async Task<Connection> OnlineAsync(Connection connection)
        {
            if(!connection.ServerHostId.IsNullOrWhiteSpace())
            {
                connection.ServerHost = new ServerHost(connection.ServerHostId);
            }

            var entity = await Repository.InsertAsync(connection, autoSave: true);
            // 
            return entity;
        }
        public Task<int> GetOnlineCountAsync(DateTime currentTime)
        {
            return Repository.CountAsync(x => x.ActiveTime > currentTime.AddSeconds(-Config.InactiveSeconds));
        }

        public Task<Connection> GetAsync(string connectionId)
        {
            return Repository.GetAsync(connectionId);
        }

        public virtual async Task<Connection> UpdateActiveTimeAsync(string connectionId)
        {
            var entity = await Repository.GetAsync(connectionId);
            entity.SetActiveTime(Clock.Now);
            return await Repository.UpdateAsync(entity, true);
        }

        public virtual Task OfflineAsync(string connectionId)
        {
            return Repository.DeleteAsync(connectionId);
        }

        public virtual async Task<int> DeleteInactiveAsync()
        {
            Expression<Func<Connection, bool>> predicate = x => x.ActiveTime < Clock.Now.AddSeconds(-Config.InactiveSeconds);

            var count = await Repository.CountAsync(predicate);

            if (count == 0)
            {
                return 0;
            }
            await Repository.DeleteAsync(predicate);

            return count;
        }
    }
}
