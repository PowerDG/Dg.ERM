using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DG.ERM.Authorization.Roles;
using DG.ERM.Authorization.Users;
using DG.ERM.MultiTenancy;
using DG.ERM.OrganizationStructure;

namespace DG.ERM.EntityFrameworkCore
{
    public class ERMDbContext : AbpZeroDbContext<Tenant, Role, User, ERMDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<DgOrganizationUnit> DgOrganizationUnits { get; set; }
        public ERMDbContext(DbContextOptions<ERMDbContext> options)
            : base(options)
        {
        }
    }
}
