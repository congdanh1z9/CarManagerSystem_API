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
    public class ImageCarConfiguration : IEntityTypeConfiguration<ImageCar>
    {
        public void Configure(EntityTypeBuilder<ImageCar> builder)
        {
            builder.HasOne(x => x.Car)
                .WithMany(x => x.ImageCars)
                .HasForeignKey(x => x.CarId);

            builder.HasOne(x => x.Stage)
                .WithMany(x => x.ImageCars)
                .HasForeignKey(x => x.StageId);
        }
    }
}
