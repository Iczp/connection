using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace IczpNet.Connection.EntityFrameworkCore;

public class ConnectionHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ConnectionHttpApiHostMigrationsDbContext>
{
    public ConnectionHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ConnectionHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Connection"));

        return new ConnectionHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
