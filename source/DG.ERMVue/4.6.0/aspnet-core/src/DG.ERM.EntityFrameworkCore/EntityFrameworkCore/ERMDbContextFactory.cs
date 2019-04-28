using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DG.ERM.Configuration;
using DG.ERM.Web;

namespace DG.ERM.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ERMDbContextFactory : IDesignTimeDbContextFactory<ERMDbContext>
    {
        public ERMDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ERMDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ERMDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ERMConsts.ConnectionStringName));

            return new ERMDbContext(builder.Options);
        }
    }
}
