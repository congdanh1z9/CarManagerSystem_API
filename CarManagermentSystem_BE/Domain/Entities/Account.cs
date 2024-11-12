using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Account : BaseEntity
    {
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public string? DateOfBirth { get; set; }
        public int? RoleId { get; set; }


        public virtual Role? Role { get; set; }
        public virtual ICollection<Blog>? Blogs { get; set; }
        public virtual ICollection<Cart>? Carts { get; set; }
        public virtual ICollection<AddressToShip>? AddressToShips { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
