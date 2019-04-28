
using Abp.Runtime.Validation;
using DG.ERM.Dtos;
using DG.ERM.OrganizationStructure;

namespace DG.ERM.OrganizationStructure.Dtos
{
    public class GetDgOrganizationUnitsInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}
