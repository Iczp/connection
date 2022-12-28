using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace IczpNet.Connection.MongoDB;

[ConnectionStringName(ConnectionDbProperties.ConnectionStringName)]
public interface IConnectionMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
