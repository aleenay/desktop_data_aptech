using System;
using System.Collections.Generic;

namespace crud_withimg.Models
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
