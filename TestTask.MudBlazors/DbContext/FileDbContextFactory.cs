using Microsoft.EntityFrameworkCore;
using TestTask.Core;
using TestTask.Migrations;

namespace TestTask.MudBlazors.DbContext
{
    public class FileDbContextFactory
    {
        public string _connectionName;

        public FileDbContextFactory(string connectionName) => _connectionName = connectionName;

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
