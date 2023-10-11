using System;
using System.Collections.Generic;

namespace miniproject_2202f2.Models
{
    public partial class TblProduct
    {

        public int StdId { get; set; }
        public string? StdName { get; set; }
        public int? StdAge { get; set; }
        public string? StdEmail { get; set; }
        public int? StdCity { get; set; }
        public string? StdProfile { get; set; }

        public virtual TblCategory? StdCityNavigation { get; set; }
    }
}
