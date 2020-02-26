using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ZCms.Controllers
{
    public abstract class ZCmsControllerBase: AbpController
    {
        protected ZCmsControllerBase()
        {
            LocalizationSourceName = ZCmsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
