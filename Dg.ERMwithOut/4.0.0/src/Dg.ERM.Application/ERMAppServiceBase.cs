using Abp.Application.Services;

namespace Dg.ERM
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ERMAppServiceBase : ApplicationService
    {
        protected ERMAppServiceBase()
        {
            LocalizationSourceName = ERMConsts.LocalizationSourceName;
        }
    }
}