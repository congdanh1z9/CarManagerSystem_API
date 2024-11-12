using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FluentAPIs
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Orders).HasForeignKey(x => x.CustomerId);

            builder.HasOne(x => x.AddressToShip)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.AddressToShipId);
        }
    }
}
