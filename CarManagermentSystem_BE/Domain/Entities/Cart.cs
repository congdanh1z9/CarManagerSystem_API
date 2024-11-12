using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cart : BaseEntity
    {
        public int? Quantity { get; set; }
        public int? CustomerId { get; set; }
        public int? CarId { get; set; }

        public virtual Account? Customer { get; set; }
        public virtual Car? Car { get; set; }    
        public virtual ICollection<ImageCar>? ImageCars { get; set; }
    }
}
