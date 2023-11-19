using Microsoft.EntityFrameworkCore;
using TestTask.Core;

namespace TestTask.Test
{
    public class TestDbContextFactory
    {
        public AppDbContext Create()
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(databaseName: "memory");
            var appDbContext = new AppDbContext(builder.Options);
            appDbContext.Database.EnsureCreated();
            return appDbContext;
        }

        /*
        public AppDbContext Create()
        {
            var sqlLiteConnection = new SqliteConnection("Data Source=:memory:");
            sqlLiteConnection.Open();

            var builder = new DbContextOptionsBuilder().UseSqlite(sqlLiteConnection);

            var dbContext = new AppDbContext(builder.Options);
            dbContext.Database.EnsureCreated();
            return dbContext;
        }
        */
    }
}
