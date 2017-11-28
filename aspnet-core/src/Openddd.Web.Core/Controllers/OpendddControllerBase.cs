using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Openddd.Controllers
{
    public abstract class OpendddControllerBase: AbpController
    {
        protected OpendddControllerBase()
        {
            LocalizationSourceName = OpendddConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
