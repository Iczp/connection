using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace IczpNet.Connection;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ConnectionHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ConnectionConsoleApiClientModule : AbpModule
{

}
