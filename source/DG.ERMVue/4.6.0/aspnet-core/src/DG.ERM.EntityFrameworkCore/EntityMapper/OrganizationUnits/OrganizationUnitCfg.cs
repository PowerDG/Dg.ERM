

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DG.ERM;

namespace DG.ERM.EntityMapper.OrganizationUnits
{
    public class OrganizationUnitCfg : IEntityTypeConfiguration<OrganizationUnit>
    {
        public void Configure(EntityTypeBuilder<OrganizationUnit> builder)
        {

            builder.ToTable("OrganizationUnits", YoYoAbpefCoreConsts.SchemaNames.CMS);

            
			builder.Property(a => a.TenantId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.Parent).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.ParentId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.Code).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.DisplayName).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.Children).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);


        }
    }
}


