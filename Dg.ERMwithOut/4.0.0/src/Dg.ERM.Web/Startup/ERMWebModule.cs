using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dg.ERM.Configuration;
using Dg.ERM.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Dg.ERM.Web.Startup
{
    [DependsOn(
        typeof(ERMApplicationModule), 
        typeof(ERMEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class ERMWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ERMWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(ERMConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<ERMNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(ERMApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ERMWebModule).GetAssembly());
        }
    }
}