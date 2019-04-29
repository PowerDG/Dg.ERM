
using Abp.Runtime.Validation;
using DG.ERM.Dtos;
using DG.ERM.DgOrganizationUnits;

namespace DG.ERM.DgOrganizationUnits.Dtos
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
