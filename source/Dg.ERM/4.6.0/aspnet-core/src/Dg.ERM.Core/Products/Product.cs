using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dg.ERM.Products
{
    public class Product : Entity, IMustHaveTenant, IMustHaveOrganizationUnit, IFullAudited
    {
        public virtual int TenantId { get; set; }

        public virtual long OrganizationUnitId { get; set; }

        public virtual string Name { get; set; }

        public virtual float Price { get; set; }
        public bool IsDeleted  { get; set; }
        public long? CreatorUserId  { get; set; }
        public DateTime CreationTime  { get; set; }
        public long? LastModifierUserId  { get; set; }
        public DateTime? LastModificationTime  { get; set; }
        public long? DeleterUserId  { get; set; }
        public DateTime? DeletionTime  { get; set; }
    }
}
