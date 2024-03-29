﻿using IczpNet.Connection.Localization;
using Volo.Abp.Application.Services;

namespace IczpNet.Connection;

public abstract class BaseAppService : ApplicationService
{
    protected BaseAppService()
    {
        LocalizationResource = typeof(ConnectionResource);
        ObjectMapperContext = typeof(ConnectionApplicationModule);
    }
}
