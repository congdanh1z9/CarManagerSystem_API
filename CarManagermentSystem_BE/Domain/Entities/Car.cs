using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Car : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? CarType { get; set; }
        public string? Color { get; set; }
        public decimal? Weight { get; set; }
        public string? Leight_Width_height { get; set; }
        public int? SupplierId { get; set; }
        public int? BrandId { get; set; }
        public int? CarTypeId { get; set; }
        public int? OriginId { get; set; }

        public virtual ICollection<Cart>? Carts { get; set; }
        public virtual Brand? Brand { get; set; }
        public virtual Origin? Origin { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual ICollection<GiftCar>? GiftCars { get; set; }
        public virtual ICollection<Blog>? Blogs { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
        public virtual ICollection<ImageCar>? ImageCars { get; set; }
        
    }
}
