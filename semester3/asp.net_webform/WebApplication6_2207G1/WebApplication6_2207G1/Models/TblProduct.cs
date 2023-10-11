using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6_2207G1.Models
{
    public partial class TblProduct
    {
        public int PId { get; set; }
        [Required(ErrorMessage = "Enter your name")]
        [Display(Name = "Product Name")]
        [StringLength(10, MinimumLength = 3 , ErrorMessage = "Minimum Length is 3")]
        public string? PName { get; set; }

        [Display(Name = "Product Price")]
        public int? PPrice { get; set; }

        [Display(Name = "Product Description")]
        [DataType(DataType.Password)]
        public string? PDes { get; set; }
        public int? CId { get; set; }

        public virtual TblCategory? CIdNavigation { get; set; }
    }
}
