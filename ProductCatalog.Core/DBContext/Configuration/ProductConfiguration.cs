using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCatalog.Core.Models.Products;

namespace ProductCatalog.Core.DBContext.Configuration
{
    public sealed class ProductConfiguration : EntityBaseConfiguration<Product>
    {
        protected override void ConfigureModel(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("product");
            builder.HasIndex(e => e.Name).IsUnique();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(128).HasColumnName("name").HasMaxLength(128);
            builder.Property(e => e.CompanyId).IsRequired().HasColumnName("companyId");
            builder.Property(e => e.CategoryId).IsRequired().HasColumnName("categoryId");
            builder.Property(e => e.TypeId).IsRequired().HasColumnName("typeId");
            builder.Property(e => e.Price).IsRequired().HasColumnName("price").HasConversion<double>();
            builder.Property(e => e.Destination).HasColumnName("destination");
            builder.HasOne(e => e.Company).WithMany(e => e.Product).HasForeignKey(e => e.CompanyId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Category).WithMany(e => e.Products).HasForeignKey(e => e.CategoryId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Type).WithMany(e => e.Products).HasForeignKey(e => e.TypeId);
        }
    }
}
