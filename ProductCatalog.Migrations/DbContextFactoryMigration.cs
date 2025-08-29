using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ProductCatalog.Core.DBContext;

namespace ProductCatalog.Migrations
{
    public class DbContextFactoryMigration : IDesignTimeDbContextFactory<AppDbContext>
    {
        private const string ConnectionName = "DbConnection";

        public AppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder().UseSqlite(
                $"Data Source={ConnectionName}.db",
                b => b.MigrationsAssembly(typeof(DbContextFactoryMigration).Assembly.FullName));

            return new AppDbContext(builder.Options);
        }
    }
}
