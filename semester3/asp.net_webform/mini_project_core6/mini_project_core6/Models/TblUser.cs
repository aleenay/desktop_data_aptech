using System;
using System.Collections.Generic;

namespace mini_project_core6.Models
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblInvoices = new HashSet<TblInvoice>();
        }

        public int UId { get; set; }
        public string? UName { get; set; }
        public string? UEmail { get; set; }
        public string? UPassword { get; set; }
        public int? UPhoneno { get; set; }

        public virtual ICollection<TblInvoice> TblInvoices { get; set; }
    }
}
