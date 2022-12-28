using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace IczpNet.Connection;

[DependsOn(
    typeof(ConnectionApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ConnectionHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ConnectionApplicationContractsModule).Assembly,
            ConnectionRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ConnectionHttpApiClientModule>();
        });

    }
}
