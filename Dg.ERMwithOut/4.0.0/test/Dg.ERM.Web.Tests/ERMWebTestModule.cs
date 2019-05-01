using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dg.ERM.Web.Startup;
namespace Dg.ERM.Web.Tests
{
    [DependsOn(
        typeof(ERMWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class ERMWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ERMWebTestModule).GetAssembly());
        }
    }
}