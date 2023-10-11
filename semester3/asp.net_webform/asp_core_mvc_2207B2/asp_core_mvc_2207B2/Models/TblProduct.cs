using System;
using System.Collections.Generic;

namespace asp_core_mvc_2207B2.Models
{
    public partial class TblProduct
    {
        public int PId { get; set; }
        public string? PName { get; set; }
        public int? PPrice { get; set; }
        public string? PDes { get; set; }
    }
}
