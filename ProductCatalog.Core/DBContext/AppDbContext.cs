using Microsoft.EntityFrameworkCore;
using ProductCatalog.Core.DBContext.Configuration;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Core.Models.Companies;
using ProductCatalog.Core.Models.Products;
using ProductCatalog.Core.Models.Types;
using ProductCatalog.Core.Models.Users;

namespace ProductCatalog.Core.DBContext
{
    public class AppDbContext(DbContextOptions options)
        : DbContext(options)
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<ProductType> Type { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
    }
}
