using Dg.ERM.Configuration;
using Dg.ERM.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Dg.ERM.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class ERMDbContextFactory : IDesignTimeDbContextFactory<ERMDbContext>
    {
        public ERMDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ERMDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(ERMConsts.ConnectionStringName)
            );

            return new ERMDbContext(builder.Options);
        }
    }
}