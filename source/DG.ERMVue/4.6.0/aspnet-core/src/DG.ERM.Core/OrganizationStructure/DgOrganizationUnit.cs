using Abp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DG.ERM.OrganizationStructure
{
    public class DgOrganizationUnit : Entity<int>
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Level { get; set; }
        public int Sorting { get; set; }
        //[EntityTypeBuilder.Ignore] 
        //public object[] ExtendedAttributes { get; set; }
        public string Operator { get; set; }
        public string RecordCreateTime { get; set; }
        public string RecordUpdateTime { get; set; }

        public int RecordStatus { get; set; }


        //public DgOrganizationUnit Parent { get; set; }
        public long? ParentId { get; set; }
        //public DgOrganizationUnit[] Children { get; set; }
        public string description { get; set; }
        public bool isActive { get; set; }

    }
}
