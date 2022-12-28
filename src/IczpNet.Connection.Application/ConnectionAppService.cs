using IczpNet.Connection.Localization;
using Volo.Abp.Application.Services;

namespace IczpNet.Connection;

public abstract class ConnectionAppService : ApplicationService
{
    protected ConnectionAppService()
    {
        LocalizationResource = typeof(ConnectionResource);
        ObjectMapperContext = typeof(ConnectionApplicationModule);
    }
}
