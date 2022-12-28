using Localization.Resources.AbpUi;
using IczpNet.Connection.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace IczpNet.Connection;

[DependsOn(
    typeof(ConnectionApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class ConnectionHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(ConnectionHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ConnectionResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
