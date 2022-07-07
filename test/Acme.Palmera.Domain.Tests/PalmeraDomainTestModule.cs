using Acme.Palmera.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.Palmera;

[DependsOn(
    typeof(PalmeraEntityFrameworkCoreTestModule)
    )]
public class PalmeraDomainTestModule : AbpModule
{

}
