using Abp.AspNetCore.Mvc.Views;

namespace Dg.ERM.Web.Views
{
    public abstract class ERMRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected ERMRazorPage()
        {
            LocalizationSourceName = ERMConsts.LocalizationSourceName;
        }
    }
}
