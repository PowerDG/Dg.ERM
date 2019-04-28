
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using DG.ERM.OrganizationStructure;

namespace  DG.ERM.OrganizationStructure.Dtos
{
    public class DgOrganizationUnitEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public int? Id { get; set; }         


        
		/// <summary>
		/// Id
		/// </summary>
 


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
		//public string RecordCreateTime { get; set; }


         



		/// <summary>
		/// ParentId
		/// </summary>
		public long? ParentId { get; set; }

         


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