using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCatalog.Core.Models.Companies;

namespace ProductCatalog.Core.DBContext.Configuration
{
    public sealed class CompanyConfiguration : EntityBaseConfiguration<Company>
    {
        protected override void ConfigureModel(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("company");
            builder.HasIndex(e => e.Name).IsUnique();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(128).HasColumnName("name").HasMaxLength(128);
            builder.Property(e => e.DateCreation).IsRequired().HasColumnName("dateCreation");
            builder.Property(e => e.Country).IsRequired().HasMaxLength(64).HasColumnName("country");
        }
    }
}
