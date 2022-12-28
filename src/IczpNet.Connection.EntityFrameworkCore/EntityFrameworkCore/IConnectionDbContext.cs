using IczpNet.Connection.ServerHosts;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace IczpNet.Connection.EntityFrameworkCore;

[ConnectionStringName(ConnectionDbProperties.ConnectionStringName)]
public interface IConnectionDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */

    DbSet<Connections.Connection> Connection { get; }
    DbSet<ServerHost> ServerHost { get; }
}
