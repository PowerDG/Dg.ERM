using Microsoft.EntityFrameworkCore;

namespace Dg.ERM.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<ERMDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for ERMDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
