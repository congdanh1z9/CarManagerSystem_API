using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        public string? Name { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public string? Status { get; set; }
        public int? CustomerId { get; set; }
        public int? AddressToShipId { get; set; }
        public int? PaymentMethodId { get; set; }

        public virtual Account? Customer { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
        public virtual AddressToShip? AddressToShip { get; set; }
    }
}
