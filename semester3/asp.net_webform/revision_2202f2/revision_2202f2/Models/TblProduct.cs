using System;
using System.Collections.Generic;

namespace revision_2202f2.Models
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblCarts = new HashSet<TblCart>();
        }

        public int PId { get; set; }
        public string? PName { get; set; }
        public int? PPrice { get; set; }
        public string? PDes { get; set; }
        public int? CId { get; set; }
        public string? PImg { get; set; }

        public virtual TblCategory? CIdNavigation { get; set; }
        public virtual ICollection<TblCart> TblCarts { get; set; }
    }
}
