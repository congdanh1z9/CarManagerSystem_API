﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Gift : BaseEntity
    {
        public string? Name { get; set; }

        public virtual ICollection<GiftCar>? GiftCars { get; set; }
    }
}
