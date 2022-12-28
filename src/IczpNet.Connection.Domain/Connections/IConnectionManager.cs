using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IczpNet.Connection.Connections
{
    public interface IConnectionManager
    {
        Task<Connection> OnlineAsync(Connection connection);
        Task<int> GetOnlineCountAsync(DateTime currentTime);
        Task<Connection> UpdateActiveTimeAsync(Guid connectionId);
        Task<Connection> GetAsync(Guid connectionId);
        Task OfflineAsync(Guid connectionId);
        Task<int> DeleteInactiveAsync();
    }
}
