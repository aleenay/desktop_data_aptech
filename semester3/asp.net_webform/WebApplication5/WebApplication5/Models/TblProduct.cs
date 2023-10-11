using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class TblProduct
    {
        public int PId { get; set; }
        public string? PName { get; set; }
        public int? PPrice { get; set; }
        public int? CId { get; set; }

        public virtual TblCategory? CIdNavigation { get; set; }
    }
}
