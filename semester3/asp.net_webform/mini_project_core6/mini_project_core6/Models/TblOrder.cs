using System;
using System.Collections.Generic;

namespace mini_project_core6.Models
{
    public partial class TblOrder
    {
        public int OId { get; set; }
        public int? ProId { get; set; }
        public DateTime? ODate { get; set; }
        public int? OQty { get; set; }
        public double? OBill { get; set; }
        public int? InvoiceId { get; set; }

        public virtual TblInvoice? Invoice { get; set; }
        public virtual TblProduct? Pro { get; set; }
    }
}
