using Acme.Palmera.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Palmera.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PalmeraController : AbpControllerBase
{
    protected PalmeraController()
    {
        LocalizationResource = typeof(PalmeraResource);
    }
}
