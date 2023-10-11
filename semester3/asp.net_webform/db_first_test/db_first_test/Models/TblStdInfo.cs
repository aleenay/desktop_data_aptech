using System;
using System.Collections.Generic;

namespace db_first_test.Models
{
    public partial class TblStdInfo
    {
        public int StdId { get; set; }
        public string? StdName { get; set; }
        public string? StdAge { get; set; }
        public int? StdCity { get; set; }
    }
}
