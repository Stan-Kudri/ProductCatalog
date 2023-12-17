using Microsoft.EntityFrameworkCore;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;
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

        public DbSet<Category> Category { get; set; }

        public DbSet<ProductType> Type { get; set; }

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

            var configurationProduct = modelBuilder.Entity<Product>();
            configurationProduct.ToTable("product");
            configurationProduct.HasKey(e => e.Id);
            configurationProduct.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            configurationProduct.HasIndex(e => e.Name).IsUnique();
            configurationProduct.Property(e => e.Name).IsRequired().HasMaxLength(128).HasColumnName("name").HasMaxLength(128);
            configurationProduct.Property(e => e.CompanyId).IsRequired().HasColumnName("companyId");
            configurationProduct.Property(e => e.CategoryId).IsRequired().HasColumnName("categoryId");
            configurationProduct.Property(e => e.TypeId).IsRequired().HasColumnName("typeId");
            configurationProduct.Property(e => e.Price).IsRequired().HasColumnType("NUMERIC").HasColumnName("price").HasConversion<double>();
            configurationProduct.Property(e => e.Destination).HasColumnName("destination");
            configurationProduct.HasOne(e => e.Company).WithMany(e => e.Product).HasForeignKey(e => e.CompanyId);
            configurationProduct.HasOne(e => e.Category).WithMany(e => e.Products).HasForeignKey(e => e.CategoryId);
            configurationProduct.HasOne(e => e.Type).WithMany(e => e.Products).HasForeignKey(e => e.TypeId);

            var configurationCategory = modelBuilder.Entity<Category>();
            configurationCategory.ToTable("category");
            configurationCategory.HasKey(e => e.Id);
            configurationCategory.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            configurationCategory.HasIndex(e => e.Name).IsUnique();
            configurationCategory.Property(e => e.Name).IsRequired().HasMaxLength(128).HasColumnName("name").HasMaxLength(128);

            var configurationType = modelBuilder.Entity<ProductType>();
            configurationType.ToTable("type");
            configurationType.HasKey(e => e.Id);
            configurationType.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            configurationType.HasIndex(e => e.Name).IsUnique();
            configurationType.Property(e => e.Name).IsRequired().HasMaxLength(128).HasColumnName("name").HasMaxLength(128);
            configurationType.HasOne(e => e.Category).WithMany(e => e.Types).HasForeignKey(e => e.CategoryId);
        }
    }
}