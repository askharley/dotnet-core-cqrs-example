using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("nvarchar(255)").HasMaxLength(255).IsRequired();
            builder.Property(x => x.Surname).HasColumnName("Surname").HasColumnType("nvarchar(255)").HasMaxLength(255).IsRequired();
            builder.Property(x => x.Handle).HasColumnName("Handle").HasColumnType("nvarchar(255)").HasMaxLength(255).IsRequired();
            builder.Property(x => x.Email).HasColumnName("Email").HasColumnType("nvarchar(255)").HasMaxLength(255).IsRequired();
        }
    }
}