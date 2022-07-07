using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.Palmera.Data;

/* This is used if database provider does't define
 * IPalmeraDbSchemaMigrator implementation.
 */
public class NullPalmeraDbSchemaMigrator : IPalmeraDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
