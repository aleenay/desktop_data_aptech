using System;
using System.Collections.Generic;

namespace miniproject_2202f2.Models
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
