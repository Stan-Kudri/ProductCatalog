using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using TestTask.Core.DBContext;

namespace TestTask.Test
{
    public class TestDbContextFactory
    {
        public AppDbContext Create()
        {
            using var sqlLiteConnection = new SqliteConnection("Data Source=:memory:");
            sqlLiteConnection.Open();

            var builder = new DbContextOptionsBuilder().UseSqlite(sqlLiteConnection);

            var dbContext = new AppDbContext(builder.Options);
            dbContext.Database.EnsureCreated();
            return dbContext;
        }
    }
}
