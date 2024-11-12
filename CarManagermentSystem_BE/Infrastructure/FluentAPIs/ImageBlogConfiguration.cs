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
    public class ImageBlogConfiguration : IEntityTypeConfiguration<ImageBlog>
    {
        public void Configure(EntityTypeBuilder<ImageBlog> builder)
        {
            builder.HasOne(x => x.Blog)
                .WithMany(x => x.ImageBlogs)
                .HasForeignKey(x => x.BlogId);
        }
    }
}
