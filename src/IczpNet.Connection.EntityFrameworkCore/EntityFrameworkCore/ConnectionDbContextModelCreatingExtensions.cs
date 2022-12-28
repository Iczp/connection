using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using Volo.Abp;
using Volo.Abp.Modularity;
using System.Linq;
using Volo.Abp.Domain.Entities;
using System.Reflection;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace IczpNet.Connection.EntityFrameworkCore;

public static class ConnectionDbContextModelCreatingExtensions
{
    public static void ConfigureConnection(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(ConnectionDbProperties.DbTablePrefix + "Questions", ConnectionDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */

        builder.ConfigEntitys<ConnectionDomainModule>(ConnectionDbProperties.DbTablePrefix, ConnectionDbProperties.DbSchema);
    }

    public static void ConfigEntitys<T>(this ModelBuilder builder, string dbTablePrefix, string dbSchema) where T : AbpModule
    {
        builder.ConfigEntitys(typeof(T), dbTablePrefix, dbSchema);
    }
    public static void ConfigEntitys(this ModelBuilder builder, Type moduleType, string dbTablePrefix, string dbSchema)
    {
        builder.ConfigEntitys(moduleType, entityType => dbTablePrefix + "_" + entityType.Name, dbSchema);
    }
    public static void ConfigEntitys(this ModelBuilder builder, Type moduleType, Func<Type, string> getTableName, string dbSchema)
    {
        var entityNamespace = moduleType.Namespace;

        var entityTypes = moduleType.Assembly.GetExportedTypes()
            .Where(t => t.Namespace.StartsWith(entityNamespace) && !t.IsAbstract
                && t.GetInterfaces().Any(x => typeof(IEntity).IsAssignableFrom(x) || x.IsGenericType && typeof(IEntity<>).IsAssignableFrom(x.GetGenericTypeDefinition())));

        foreach (var t in entityTypes)
        {
            builder.Entity(t, b =>
            {
                var tableAttribute = t.GetCustomAttribute<TableAttribute>();

                if (tableAttribute != null)
                {
                    b.ToTable(tableAttribute.Name, tableAttribute.Schema);
                }
                else
                {
                    b.ToTable(getTableName(t), dbSchema);
                }

                b.ConfigureByConvention();
            });
        }
    }
}
