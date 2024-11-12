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
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasOne(x => x.Account)
                .WithMany(x => x.Blogs)
                .HasForeignKey(x => x.AccountId);

            builder.HasOne(x => x.Car)
                .WithMany(x => x.Blogs)
                .HasForeignKey(x => x.CarId);
        }
    }
}
