using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasColumnName("Title").HasColumnType("nvarchar(255)").HasMaxLength(255).IsRequired();
            builder.Property(x => x.Content).HasColumnName("Content").HasColumnType("nvarchar(2000)").HasMaxLength(2000).IsRequired();
        }
    }
}