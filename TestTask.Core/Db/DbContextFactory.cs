using System;

namespace TestTask.Core.Db
{
    public class DbContextFactory
    {
        public void EnsureCreated(string connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentException("Name connection string cannot be empty.");
            }

            using (var db = new AppDbContext(connectionString))
            {
                if (!db.Database.CreateIfNotExists())
                {
                    db.Database.ExecuteSqlCommand(
                        "CREATE TABLE IF NOT EXISTS User" +
                        "(Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,Username TEXT NOT NULL UNIQUE, PasswordHash TEXT NOT NULL)");
                }
            }
        }
    }
}
