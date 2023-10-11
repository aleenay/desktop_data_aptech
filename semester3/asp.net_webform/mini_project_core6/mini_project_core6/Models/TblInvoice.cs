using System;
using System.Collections.Generic;

namespace mini_project_core6.Models
{
    public partial class TblInvoice
    {
        public TblInvoice()
        {
            TblOrders = new HashSet<TblOrder>();
        }

        public int InvoiceId { get; set; }
        public int? UserId { get; set; }
        public double? InvoiceTotalbill { get; set; }

        public virtual TblUser? User { get; set; }
        public virtual ICollection<TblOrder> TblOrders { get; set; }
    }
}
