using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderDetail : BaseEntity
    {
        public decimal? CurrentPrice { get; set; }
        public int? Quantity { get; set; }
        public decimal? Tax { get; set; }
        public int? OrderId { get; set; }
        public int? CarId { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Car? Car { get; set; }

    }
}
