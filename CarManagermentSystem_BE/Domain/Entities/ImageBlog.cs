using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ImageBlog : BaseEntity
    {
        public string? ImageLink { get; set; }
        public int? BlogId { get; set; }    

        public virtual Blog? Blog { get; set; }
    }
}
