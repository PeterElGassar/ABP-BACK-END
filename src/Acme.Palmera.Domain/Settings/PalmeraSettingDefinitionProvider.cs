using Volo.Abp.Settings;

namespace Acme.Palmera.Settings;

public class PalmeraSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PalmeraSettings.MySetting1));
    }
}
