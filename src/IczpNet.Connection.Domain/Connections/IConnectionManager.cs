using System;
using System.Threading.Tasks;

namespace IczpNet.Connection.Connections
{
    public interface IConnectionManager
    {
        /// <summary>
        /// Online
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        Task<Connection> CreateAsync(Connection connection);
        Task<int> GetOnlineCountAsync(DateTime currentTime);
        Task<Connection> UpdateActiveTimeAsync(string connectionId);
        Task<Connection> GetAsync(string connectionId);
        /// <summary>
        /// Offline
        /// </summary>
        /// <param name="connectionId"></param>
        /// <returns></returns>
        Task DeleteAsync(string connectionId);
        Task<int> ClearUnactiveAsync();
    }
}
