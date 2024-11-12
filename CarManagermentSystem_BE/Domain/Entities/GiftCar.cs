using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GiftCar : BaseEntity
    {
        public int? Quantity { get; set; }
        public int? CarId { get; set; }
        public int? GiftId { get; set; }

        public virtual Car? Car { get; set; }
        public virtual Gift? Gift { get; set; }  
    }
}
