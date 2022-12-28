using Volo.Abp.Modularity;

namespace IczpNet.Connection;

[DependsOn(
    typeof(ConnectionApplicationModule),
    typeof(ConnectionDomainTestModule)
    )]
public class ConnectionApplicationTestModule : AbpModule
{

}
