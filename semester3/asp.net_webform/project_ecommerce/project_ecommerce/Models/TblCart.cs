using System;
using System.Collections.Generic;

namespace project_ecommerce.Models
{
    public partial class TblCart
    {
        public int ItemId { get; set; }
        public int? ProductId { get; set; }
        public int? UserId { get; set; }

        public virtual TblProduct? Product { get; set; }
        public virtual TblUser? User { get; set; }
    }
}
