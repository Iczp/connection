using Volo.Abp;
using Volo.Abp.MongoDB;

namespace IczpNet.Connection.MongoDB;

public static class ConnectionMongoDbContextExtensions
{
    public static void ConfigureConnection(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
