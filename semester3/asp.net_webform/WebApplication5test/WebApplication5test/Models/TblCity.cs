using System;
using System.Collections.Generic;

namespace WebApplication5test.Models
{
    public partial class TblCity
    {
        public TblCity()
        {
            TblStds = new HashSet<TblStd>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<TblStd> TblStds { get; set; }
    }
}
