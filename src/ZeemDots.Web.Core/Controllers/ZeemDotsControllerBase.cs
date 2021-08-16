using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ZeemDots.Controllers
{
    public abstract class ZeemDotsControllerBase: AbpController
    {
        protected ZeemDotsControllerBase()
        {
            LocalizationSourceName = ZeemDotsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
