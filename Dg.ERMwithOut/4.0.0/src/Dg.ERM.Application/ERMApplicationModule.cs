using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Dg.ERM
{
    [DependsOn(
        typeof(ERMCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ERMApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ERMApplicationModule).GetAssembly());
        }
    }
}