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
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasOne(x => x.Supplier)
                .WithMany(x => x.Cars)
                .HasForeignKey(x => x.SupplierId);

            builder.HasOne(x => x.Brand)
                .WithMany(x => x.Cars)
                .HasForeignKey(x => x.BrandId);

            builder.HasOne(x => x.Origin)
                .WithMany(x => x.Cars)
                .HasForeignKey(x => x.OriginId);

        }
    }
}
