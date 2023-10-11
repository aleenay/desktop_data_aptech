using System;
using System.Collections.Generic;

namespace WebApplication5.Models
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
