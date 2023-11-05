using Microsoft.EntityFrameworkCore;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Users;

namespace TestTask.Core
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var configurationUser = modelBuilder.Entity<User>();
            configurationUser.ToTable("user");
            configurationUser.HasKey(e => e.Id);
            configurationUser.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            configurationUser.HasIndex(e => e.Username).IsUnique();
            configurationUser.Property(e => e.Username).IsRequired().HasColumnName("username").HasMaxLength(128);
            configurationUser.Property(e => e.PasswordHash).IsRequired().HasColumnName("passwordHash").HasMaxLength(128);

            var configurationCompany = modelBuilder.Entity<Company>();
            configurationCompany.ToTable("company");
            configurationCompany.HasKey(e => e.Id);
            configurationCompany.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            configurationCompany.HasIndex(e => e.Name).IsUnique();
            configurationCompany.Property(e => e.Name).IsRequired().HasMaxLength(128).HasColumnName("name").HasMaxLength(128);
            configurationCompany.Property(e => e.DateCreation).IsRequired().HasColumnType("DATETIME").HasColumnName("dateCreation");
            configurationCompany.Property(e => e.Country).IsRequired().HasMaxLength(64).HasColumnName("country");
            configurationCompany.HasMany(e => e.Product).WithOne().HasForeignKey(e => e.CompanyId);

            var configurationProduct = modelBuilder.Entity<Product>();
            configurationProduct.ToTable("product");
            configurationProduct.HasKey(e => e.Id);
            configurationProduct.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            configurationProduct.Property(e => e.CompanyId).IsRequired().HasColumnName("companyId");
            configurationProduct.Property(e => e.Category).IsRequired().HasColumnName("category").HasMaxLength(128);
            configurationProduct.Property(e => e.Type).IsRequired().HasColumnName("type").HasMaxLength(128);
            configurationProduct.Property(e => e.Price).IsRequired().HasColumnType("NUMERIC").HasColumnName("price");
            configurationProduct.Property(e => e.Destination).HasColumnName("destination");
        }
    }
}