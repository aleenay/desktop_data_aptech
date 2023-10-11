using System;
using System.Collections.Generic;

namespace WebApplication5test.Models
{
    public partial class TblEmpDetail
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public long? Phoneno { get; set; }
        public int? Age { get; set; }
    }
}
