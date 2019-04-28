using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Dg.ERM.Authorization.Roles;
using Dg.ERM.Authorization.Users;
using Dg.ERM.MultiTenancy;

namespace Dg.ERM.EntityFrameworkCore
{
    public class ERMDbContext : AbpZeroDbContext<Tenant, Role, User, ERMDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ERMDbContext(DbContextOptions<ERMDbContext> options)
            : base(options)
        {
        }
    }
}
