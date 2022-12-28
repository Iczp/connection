﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace IczpNet.Connection.EntityFrameworkCore;

public class ConnectionHttpApiHostMigrationsDbContext : AbpDbContext<ConnectionHttpApiHostMigrationsDbContext>
{
    public ConnectionHttpApiHostMigrationsDbContext(DbContextOptions<ConnectionHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureConnection();
    }
}
