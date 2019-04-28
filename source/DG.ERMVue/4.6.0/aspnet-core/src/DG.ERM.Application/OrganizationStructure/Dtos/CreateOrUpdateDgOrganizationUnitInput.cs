

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DG.ERM.OrganizationStructure;

namespace DG.ERM.OrganizationStructure.Dtos
{
    public class CreateOrUpdateDgOrganizationUnitInput
    {
        [Required]
        public DgOrganizationUnitEditDto DgOrganizationUnit { get; set; }

    }
}