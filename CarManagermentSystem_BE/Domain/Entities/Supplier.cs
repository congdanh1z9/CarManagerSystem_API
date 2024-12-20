﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Supplier : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; } 
        public string? Email { get; set; } 
        public string? Phone { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<Car>? Cars { get; set; }
    }
}
