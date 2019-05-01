using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dg.ERM.EntityFrameworkCore
{
    public class ERMDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public ERMDbContext(DbContextOptions<ERMDbContext> options) 
            : base(options)
        {

        }
    }
}
