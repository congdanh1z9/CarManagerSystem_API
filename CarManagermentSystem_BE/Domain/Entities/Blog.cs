using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Blog : BaseEntity
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Status { get; set; }
        public string? ImageBlogId { get; set; }
        public string? CarId { get; set; }
        public string? AccountId { get; set; }
        
        public virtual ICollection<ImageBlog>? ImageBlogs { get; set; }
        public virtual Account? Account { get; set; }
        public virtual Car? Car { get; set; }   
    }
}
