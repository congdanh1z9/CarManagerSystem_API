﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PaymentMethod : BaseEntity 
    {
        public string? Name { get; set; }

        public virtual IEnumerable<Order>? Orders { get; set; }
    }
}
