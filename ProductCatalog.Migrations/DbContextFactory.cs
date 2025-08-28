using Microsoft.EntityFrameworkCore;
using ProductCatalog.Core.DBContext;

namespace ProductCatalog.Migrations
{
    public class DbContextFactory(string connectionName)
    {
        public AppDbContext Create()
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>().UseSqlite($"Data Source={connectionName}.db", x =>
            {
                x.MigrationsAssembly(typeof(DbContextFactoryMigration).Assembly.FullName);
            });

            var dbContext = new AppDbContext(builder.Options);
            dbContext.Migrate();

            return dbContext;
        }
    }
}
