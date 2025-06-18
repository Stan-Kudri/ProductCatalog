using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using TestTask.Core.DBContext;

namespace TestTask.Test
{
    public class TestDbContextFactory
    {
        public AppDbContext Create()
        {
#pragma warning disable CA2000 // Dispose objects before losing scope
            var sqlLiteConnection = new SqliteConnection("Data Source=:memory:");
#pragma warning restore CA2000 // Dispose objects before losing scope

            sqlLiteConnection.Open();
            var builder = new DbContextOptionsBuilder().UseSqlite(sqlLiteConnection);

            var dbContext = new AppDbContext(builder.Options);
            dbContext.Database.EnsureCreated();
            return dbContext;
        }
    }
}
