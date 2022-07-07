using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.Palmera;

[Dependency(ReplaceServices = true)]
public class PalmeraBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Palmera";
}
