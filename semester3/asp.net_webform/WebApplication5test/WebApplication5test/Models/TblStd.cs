using System;
using System.Collections.Generic;

namespace WebApplication5test.Models
{
    public partial class TblStd
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public int? City { get; set; }

        public virtual TblCity? CityNavigation { get; set; }
    }
}
