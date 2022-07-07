using System;
using System.Collections.Generic;
using System.Text;
using Acme.Palmera.Localization;
using Volo.Abp.Application.Services;

namespace Acme.Palmera;

/* Inherit your application services from this class.
 */
public abstract class PalmeraAppService : ApplicationService
{
    protected PalmeraAppService()
    {
        LocalizationResource = typeof(PalmeraResource);
    }
}
