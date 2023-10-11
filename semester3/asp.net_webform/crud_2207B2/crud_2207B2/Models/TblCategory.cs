using System;
using System.Collections.Generic;

namespace crud_2207B2.Models
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            TblStds = new HashSet<TblStd>();
        }

        public int CId { get; set; }
        public string? CName { get; set; }

        public virtual ICollection<TblStd> TblStds { get; set; }
    }
}
