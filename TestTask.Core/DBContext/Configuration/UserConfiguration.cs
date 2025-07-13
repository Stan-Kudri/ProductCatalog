using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTask.Core.Models.Users;

namespace TestTask.Core.DBContext.Configuration
{
    public sealed class UserConfiguration : EntityBaseConfiguration<User>
    {
        protected override void ConfigureModel(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");
            builder.HasIndex(e => e.Username).IsUnique();
            builder.Property(e => e.Username).IsRequired().HasColumnName("username").HasMaxLength(128);
            builder.Property(e => e.PasswordHash).IsRequired().HasColumnName("passwordHash").HasMaxLength(128);
            builder.Property(e => e.UserRole).IsRequired()
                                             .HasColumnName("role")
                                             .HasDefaultValue(UserRole.Basic)
                                             .HasConversion(e => e.Name,
                                                                 e => UserRole.List.FirstOrDefault(role => role.Name == e) ?? UserRole.Basic);
        }
    }
}
