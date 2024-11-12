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
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Carts)
                .HasForeignKey(x => x.CustomerId);

            builder.HasOne(x => x.Car)
                .WithMany(x => x.Carts)
                .HasForeignKey(x => x.CarId);
        }
    }
}
