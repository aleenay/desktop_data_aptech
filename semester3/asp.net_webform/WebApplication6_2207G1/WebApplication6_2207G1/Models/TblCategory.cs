using System;
using System.Collections.Generic;

namespace WebApplication6_2207G1.Models
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            TblProducts = new HashSet<TblProduct>();
        }

        public int CId { get; set; }
        public string? CName { get; set; }

        public virtual ICollection<TblProduct> TblProducts { get; set; }
    }
}
