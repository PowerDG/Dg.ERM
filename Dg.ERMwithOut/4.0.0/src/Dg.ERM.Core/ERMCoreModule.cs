using Abp.Modules;
using Abp.Reflection.Extensions;
using Dg.ERM.Localization;

namespace Dg.ERM
{
    public class ERMCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            ERMLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ERMCoreModule).GetAssembly());
        }
    }
}