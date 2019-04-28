

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using DG.ERM.OrganizationStructure;

namespace DG.ERM.OrganizationStructure.Dtos
{
    public class DgOrganizationUnitListDto : EntityDto<int> 
    {

        
		/// <summary>
		/// Id
		/// </summary>
		public int? Id { get; set; }



		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }



		/// <summary>
		/// Code
		/// </summary>
		public string Code { get; set; }



		/// <summary>
		/// Type
		/// </summary>
		public string Type { get; set; }



		/// <summary>
		/// Level
		/// </summary>
		public string Level { get; set; }



		/// <summary>
		/// Sorting
		/// </summary>
		public int Sorting { get; set; }



		/// <summary>
		/// Operator
		/// </summary>
		public string Operator { get; set; }



		/// <summary>
		/// RecordCreateTime
		/// </summary>
		public string RecordCreateTime { get; set; }



		/// <summary>
		/// RecordUpdateTime
		/// </summary>
		public string RecordUpdateTime { get; set; }



		/// <summary>
		/// RecordStatus
		/// </summary>
		public int RecordStatus { get; set; }



		/// <summary>
		/// Parent
		/// </summary>
		public DgOrganizationUnit Parent { get; set; }



		/// <summary>
		/// ParentId
		/// </summary>
		public long? ParentId { get; set; }



		/// <summary>
		/// Children
		/// </summary>
		public DgOrganizationUnit[] Children { get; set; }



		/// <summary>
		/// description
		/// </summary>
		public string description { get; set; }



		/// <summary>
		/// isActive
		/// </summary>
		public bool isActive { get; set; }




    }
}