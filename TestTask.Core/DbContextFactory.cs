using Microsoft.EntityFrameworkCore;

namespace TestTask.Core
{
    public class DbContextFactory
    {
        public string _connectionName;

        public DbContextFactory(string connectionName) => _connectionName = connectionName;

        public AppDbContext Create()
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>().UseSqlite($"Data Source={_connectionName}.db");
            var appDbContext = new AppDbContext(builder.Options);
            appDbContext.Database.EnsureCreated();
            return appDbContext;
        }
    }
}
