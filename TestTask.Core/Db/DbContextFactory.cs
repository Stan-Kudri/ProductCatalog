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
                    db.Database.ExecuteSqlCommand(
                        "CREATE TABLE IF NOT EXISTS Modes" +
                        "(ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,Name TEXT NOT NULL, MaxBottleNumber INTEGER NOT NULL, MaxUsedTips INTEGER NOT NULL)");
                    db.Database.ExecuteSqlCommand(
                        "CREATE TABLE IF NOT EXISTS Steps" +
                        "(ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,ModeId INTEGER NOT NULL, Timer INTEGER NOT NULL,Destination TEXT, Speed INTEGER NOT NULL, Type TEXT NOT NULL, Volume INTEGER NOT NULL)");
                }
            }
        }
    }
}
