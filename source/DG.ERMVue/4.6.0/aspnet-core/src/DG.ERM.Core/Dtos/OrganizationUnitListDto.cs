

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using DG.ERM;

namespace DG.ERM.Dtos
{
    public class OrganizationUnitListDto : FullAuditedEntityDto<long>,IMayHaveTenant 
    {

        
		/// <summary>
		/// TenantId
		/// </summary>
		public int? TenantId { get; set; }



		/// <summary>
		/// Parent
		/// </summary>
		public OrganizationUnit Parent { get; set; }



		/// <summary>
		/// ParentId
		/// </summary>
		public long? ParentId { get; set; }



		/// <summary>
		/// Code
		/// </summary>
		[Required(ErrorMessage="Code不能为空")]
		public string Code { get; set; }



		/// <summary>
		/// DisplayName
		/// </summary>
		[Required(ErrorMessage="DisplayName不能为空")]
		public string DisplayName { get; set; }



		/// <summary>
		/// Children
		/// </summary>
		public ICollection<OrganizationUnit> Children { get; set; }




    }
}