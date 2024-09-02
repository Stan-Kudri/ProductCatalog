using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTask.Core.Models.Categories;

namespace TestTask.Core.DBContext.Configuration
{
    public sealed class CategoryConfiguration : EntityBaseConfiguration<Category>
    {
        protected override void ConfigureModel(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("category");
            builder.HasIndex(e => e.Name).IsUnique();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(128).HasColumnName("name").HasMaxLength(128);
        }
    }
}
