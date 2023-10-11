using System;
using System.Collections.Generic;

namespace mini_project_core6.Models
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblOrders = new HashSet<TblOrder>();
        }

        public int PId { get; set; }
        public string? PName { get; set; }
        public int? PPrice { get; set; }
        public string? PDes { get; set; }
        public string? PImg { get; set; }
        public int? CatId { get; set; }

        public virtual TblCategory? Cat { get; set; }
        public virtual ICollection<TblOrder> TblOrders { get; set; }
    }
}
