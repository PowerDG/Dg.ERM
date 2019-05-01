using Abp.AspNetCore.Mvc.Controllers;

namespace Dg.ERM.Web.Controllers
{
    public abstract class ERMControllerBase: AbpController
    {
        protected ERMControllerBase()
        {
            LocalizationSourceName = ERMConsts.LocalizationSourceName;
        }
    }
}