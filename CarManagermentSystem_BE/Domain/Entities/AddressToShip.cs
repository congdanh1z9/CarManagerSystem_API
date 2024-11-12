using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AddressToShip : BaseEntity
    {
        public string? AddressLine {  get; set; }
        public int? CustomerId { get; set; }

        public virtual Account? Customer { get; set; }  
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
