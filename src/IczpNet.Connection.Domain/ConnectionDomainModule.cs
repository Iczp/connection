using IczpNet.Connection.Works;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace IczpNet.Connection;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ConnectionDomainSharedModule)
)]
public class ConnectionDomainModule : AbpModule
{
    public override async Task OnPostApplicationInitializationAsync(ApplicationInitializationContext context)
    {
        await context.AddBackgroundWorkerAsync<ConnectionWorker>();
        await base.OnPostApplicationInitializationAsync(context);
    }
}
