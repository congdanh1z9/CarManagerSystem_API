using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.FluentAPIs
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasOne(x => x.Order)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.OrderId);

            builder.HasOne(x => x.Car)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.CarId);

        }
    }
}
