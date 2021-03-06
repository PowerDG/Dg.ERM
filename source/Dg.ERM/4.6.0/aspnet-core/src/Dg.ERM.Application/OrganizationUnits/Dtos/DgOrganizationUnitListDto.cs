

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using DG.ERM.DgOrganizationUnits;
using Abp.Organizations;
using System.Collections.Generic;

namespace DG.ERM.DgOrganizationUnits.Dtos
{
    public class DgOrganizationUnitListDto   
    {

        
		/// <summary>
		/// Code
		/// </summary>
		public string Code { get; set; }



		/// <summary>
		/// ParentId
		/// </summary>
		public long? ParentId { get; set; }



		/// <summary>
		/// TenantId
		/// </summary>
		public int? TenantId { get; set; }



		/// <summary>
		/// Parent
		/// </summary>
		public OrganizationUnit Parent { get; set; }



		/// <summary>
		/// DisplayName
		/// </summary>
		public string DisplayName { get; set; }



		/// <summary>
		/// Children
		/// </summary>
		public ICollection<OrganizationUnit> Children { get; set; }



		/// <summary>
		/// IsActive
		/// </summary>
		public bool IsActive { get; set; }



		/// <summary>
		/// ExtensionData
		/// </summary>
		public string ExtensionData { get; set; }



		/// <summary>
		/// IsDeleted
		/// </summary>
		public bool IsDeleted { get; set; }



		/// <summary>
		/// CreatorUserId
		/// </summary>
		public long? CreatorUserId { get; set; }



		/// <summary>
		/// CreationTime
		/// </summary>
		public DateTime CreationTime { get; set; }



		/// <summary>
		/// LastModifierUserId
		/// </summary>
		public long? LastModifierUserId { get; set; }



		/// <summary>
		/// LastModificationTime
		/// </summary>
		public DateTime? LastModificationTime { get; set; }



		/// <summary>
		/// DeleterUserId
		/// </summary>
		public long? DeleterUserId { get; set; }



		/// <summary>
		/// DeletionTime
		/// </summary>
		public DateTime? DeletionTime { get; set; }



		/// <summary>
		/// Id
		/// </summary>
		public int? Id { get; set; }



		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }



		/// <summary>
		/// Type
		/// </summary>
		public string Type { get; set; }



		/// <summary>
		/// Level
		/// </summary>
		public string Level { get; set; }



		/// <summary>
		/// Sort
		/// </summary>
		public int Sort { get; set; }



		/// <summary>
		/// ExtendedAttributes
		/// </summary>
		public object[] ExtendedAttributes { get; set; }



		/// <summary>
		/// Operator
		/// </summary>
		public string Operator { get; set; }



		/// <summary>
		/// description
		/// </summary>
		public string description { get; set; }



		/// <summary>
		/// RecordStatus
		/// </summary>
		public int RecordStatus { get; set; }




    }
}