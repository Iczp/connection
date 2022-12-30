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
        Task<Connection> UpdateActiveTimeAsync(string connectionId);
        Task<Connection> GetAsync(string connectionId);
        Task OfflineAsync(string connectionId);
        Task<int> DeleteInactiveAsync();
    }
}
