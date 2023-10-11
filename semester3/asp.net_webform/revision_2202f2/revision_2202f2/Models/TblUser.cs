using System;
using System.Collections.Generic;

namespace revision_2202f2.Models
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblCarts = new HashSet<TblCart>();
        }

        public int UId { get; set; }
        public string? UName { get; set; }
        public string? UEmail { get; set; }
        public string? UPassword { get; set; }
        public int? UPhoneno { get; set; }

        public virtual ICollection<TblCart> TblCarts { get; set; }
    }
}
