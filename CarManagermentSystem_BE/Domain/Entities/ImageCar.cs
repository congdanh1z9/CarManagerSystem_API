using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ImageCar : BaseEntity
    {
        public string? ImageLink { get; set; }
        public int? CarId { get; set; }
        public int StageId { get; set; }

        public virtual Car? Car { get; set; }   
        public virtual Stage? Stage { get; set; }
    }
}
