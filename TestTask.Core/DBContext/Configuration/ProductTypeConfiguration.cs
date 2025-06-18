using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTask.Core.Models.Types;

namespace TestTask.Core.DBContext.Configuration
{
    public sealed class ProductTypeConfiguration : EntityBaseConfiguration<ProductType>
    {
        protected override void ConfigureModel(EntityTypeBuilder<ProductType> builder)
        {
            builder.ToTable("type");
            builder.HasIndex(e => e.Name).IsUnique();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(128).HasColumnName("name").HasMaxLength(128);
            builder.HasOne(e => e.Category).WithMany(e => e.Types).HasForeignKey(e => e.CategoryId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
