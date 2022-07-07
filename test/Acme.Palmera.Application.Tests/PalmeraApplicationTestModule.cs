using Volo.Abp.Modularity;

namespace Acme.Palmera;

[DependsOn(
    typeof(PalmeraApplicationModule),
    typeof(PalmeraDomainTestModule)
    )]
public class PalmeraApplicationTestModule : AbpModule
{

}
