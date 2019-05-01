using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Dg.ERM.EntityFrameworkCore
{
    [DependsOn(
        typeof(ERMCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class ERMEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ERMEntityFrameworkCoreModule).GetAssembly());
        }
    }
}