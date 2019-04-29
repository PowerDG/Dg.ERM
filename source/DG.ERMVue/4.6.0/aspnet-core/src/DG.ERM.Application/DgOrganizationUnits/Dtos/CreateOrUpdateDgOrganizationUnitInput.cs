

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DG.ERM.DgOrganizationUnits;

namespace DG.ERM.DgOrganizationUnits.Dtos
{
    public class CreateOrUpdateDgOrganizationUnitInput
    {
        [Required]
        public DgOrganizationUnitEditDto DgOrganizationUnit { get; set; }

    }
}