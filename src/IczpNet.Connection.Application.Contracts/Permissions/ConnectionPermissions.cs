using Volo.Abp.Reflection;

namespace IczpNet.Connection.Permissions;

public class ConnectionPermissions
{
    public const string GroupName = "Connection";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ConnectionPermissions));
    }
}
