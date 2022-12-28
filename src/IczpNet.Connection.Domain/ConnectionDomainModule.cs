using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace IczpNet.Connection;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ConnectionDomainSharedModule)
)]
public class ConnectionDomainModule : AbpModule
{

}
