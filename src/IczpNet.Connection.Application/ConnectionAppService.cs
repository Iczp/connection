using IczpNet.Connection.Connections;
using IczpNet.Connection.Dtos;
using System;
using System.Threading.Tasks;
using Volo.Abp.ObjectMapping;

namespace IczpNet.Connection
{
    public class ConnectionAppService : BaseAppService, IConnectionAppService
    {
        protected IConnectionManager ConnectionManager { get; }

        public ConnectionAppService(IConnectionManager connectionManager)
        {
            ConnectionManager = connectionManager;
        }

        public Task OfflineAsync(string id)
        {
            return ConnectionManager.OfflineAsync(id);
        }

        public async Task<ConnectionDto> OnlineAsync(ConnectionCreateInput input)
        {
            var entity = await MapToEntityAsync(input);
            var result = await ConnectionManager.OnlineAsync(entity);
            return ObjectMapper.Map<Connections.Connection, ConnectionDto>(result);
        }

        private Task<Connections.Connection> MapToEntityAsync(ConnectionCreateInput input)
        {
            var entity = ObjectMapper.Map<ConnectionCreateInput, Connections.Connection>(input);
            entity.SetConnectionId(input.Id);
            return Task.FromResult(entity);
        }
    }
}
