using IczpNet.Connection.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace IczpNet.Connection.Permissions;

public class ConnectionPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ConnectionPermissions.GroupName, L("Permission:Connection"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ConnectionResource>(name);
    }
}
