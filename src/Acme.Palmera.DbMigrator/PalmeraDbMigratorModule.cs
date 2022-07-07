using Acme.Palmera.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.Palmera.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PalmeraEntityFrameworkCoreModule),
    typeof(PalmeraApplicationContractsModule)
    )]
public class PalmeraDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
