using IczpNet.Connection.Dtos;
using System;
using System.Threading.Tasks;

namespace IczpNet.Connection
{
    public interface IConnectionAppService
    {
        Task<ConnectionDto> OnlineAsync(ConnectionCreateInput input);

        Task OfflineAsync(string id);
    }
}
