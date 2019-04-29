
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Dg.ERM.Products;

namespace  Dg.ERM.Products.Dtos
{
    public class ProductEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public int? Id { get; set; }         


        
		/// <summary>
		/// TenantId
		/// </summary>
		public int TenantId { get; set; }



		/// <summary>
		/// OrganizationUnitId
		/// </summary>
		public long OrganizationUnitId { get; set; }



		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }



		/// <summary>
		/// Price
		/// </summary>
		public float Price { get; set; }




    }
}