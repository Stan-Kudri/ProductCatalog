using Microsoft.EntityFrameworkCore;
using System;

namespace TestTask.Core.Db
{
    public class DbContextFactory
    {
        public AppDbContext EnsureCreated(string connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentException("Name connection string cannot be empty.");
            }

            var builder = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlite(connectionString);

            using (var db = new AppDbContext(builder.Options))
            {
                db.Database.EnsureCreated();
                return db;
            }
        }
    }
}
