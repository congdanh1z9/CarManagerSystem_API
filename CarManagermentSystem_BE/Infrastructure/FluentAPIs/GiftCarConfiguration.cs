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
    public class GiftCarConfiguration : IEntityTypeConfiguration<GiftCar>
    {
        public void Configure(EntityTypeBuilder<GiftCar> builder)
        {
            builder.HasOne(x => x.Car)
                .WithMany(x => x.GiftCars)
                .HasForeignKey(x => x.CarId);

            builder.HasOne(x => x.Gift)
                .WithMany(x => x.GiftCars)
                .HasForeignKey(x => x.GiftId);
        }
    }
}
