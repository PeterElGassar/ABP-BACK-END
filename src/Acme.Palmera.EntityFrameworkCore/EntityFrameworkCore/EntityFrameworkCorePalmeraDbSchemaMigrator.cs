using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.Palmera.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.Palmera.EntityFrameworkCore;

public class EntityFrameworkCorePalmeraDbSchemaMigrator
    : IPalmeraDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorePalmeraDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the PalmeraDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<PalmeraDbContext>()
            .Database
            .MigrateAsync();
    }
}
