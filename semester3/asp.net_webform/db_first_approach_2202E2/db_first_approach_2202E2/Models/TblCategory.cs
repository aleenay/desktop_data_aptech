using System;
using System.Collections.Generic;

namespace db_first_approach_2202E2.Models
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
