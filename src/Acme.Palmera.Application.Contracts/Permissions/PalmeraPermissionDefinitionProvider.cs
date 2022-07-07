using Acme.Palmera.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.Palmera.Permissions;

public class PalmeraPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PalmeraPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PalmeraPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PalmeraResource>(name);
    }
}
