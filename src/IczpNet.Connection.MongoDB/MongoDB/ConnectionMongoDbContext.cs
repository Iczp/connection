using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace IczpNet.Connection.MongoDB;

[ConnectionStringName(ConnectionDbProperties.ConnectionStringName)]
public class ConnectionMongoDbContext : AbpMongoDbContext, IConnectionMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureConnection();
    }
}
