using System.Threading.Tasks;

namespace Acme.Palmera.Data;

public interface IPalmeraDbSchemaMigrator
{
    Task MigrateAsync();
}
