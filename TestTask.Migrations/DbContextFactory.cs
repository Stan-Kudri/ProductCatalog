using Microsoft.EntityFrameworkCore;
using TestTask.Core;

namespace TestTask.Migrations
{
    public class DbContextFactory
    {
        public string _connectionName;

        public DbContextFactory(string connectionName) => _connectionName = connectionName;

        public AppDbContext Create()
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>().UseSqlite($"Data Source={_connectionName}.db", x =>
            {
                x.MigrationsAssembly(typeof(DbContextFactoryMigration).Assembly.FullName);
            });

            var dbContext = new AppDbContext(builder.Options);
            dbContext.Database.Migrate();

            return dbContext;
        }
    }
}
