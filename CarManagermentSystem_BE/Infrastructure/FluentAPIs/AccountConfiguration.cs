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
    public class BaseEntityConfiguration : IEntityTypeConfiguration<BaseEntity>
    {
        public void Configure(EntityTypeBuilder<BaseEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
               .ValueGeneratedOnAdd();
        }
    }
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasOne(x => x.Role)
                .WithMany(x => x.Accounts)
                .HasForeignKey(x => x.RoleId);
        }
    }
}
