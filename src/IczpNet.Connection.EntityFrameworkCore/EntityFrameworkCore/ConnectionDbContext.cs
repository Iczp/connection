using IczpNet.Connection.ServerHosts;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace IczpNet.Connection.EntityFrameworkCore;

[ConnectionStringName(ConnectionDbProperties.ConnectionStringName)]
public class ConnectionDbContext : AbpDbContext<ConnectionDbContext>, IConnectionDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DbSet<Connections.Connection> Connection { get; }
    public DbSet<ServerHost> ServerHost { get; }

    public ConnectionDbContext(DbContextOptions<ConnectionDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureConnection();
    }
}
