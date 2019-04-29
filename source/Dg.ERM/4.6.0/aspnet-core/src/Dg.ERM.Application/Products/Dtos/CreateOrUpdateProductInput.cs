

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dg.ERM.Products;

namespace Dg.ERM.Products.Dtos
{
    public class CreateOrUpdateProductInput
    {
        [Required]
        public ProductEditDto Product { get; set; }

    }
}