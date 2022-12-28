using IczpNet.Connection.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace IczpNet.Connection;

public abstract class ConnectionController : AbpControllerBase
{
    protected ConnectionController()
    {
        LocalizationResource = typeof(ConnectionResource);
    }
}
