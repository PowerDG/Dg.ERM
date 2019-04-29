

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DG.ERM;

namespace DG.ERM.Dtos
{
    public class CreateOrUpdateOrganizationUnitInput
    {
        [Required]
        public OrganizationUnitEditDto OrganizationUnit { get; set; }

    }
}