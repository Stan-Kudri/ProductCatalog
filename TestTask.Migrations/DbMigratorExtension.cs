using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;
using TestTask.Core.DBContext;

namespace TestTask.Migrations
{
    public static class DbMigratorExtension
    {
        public static void Migrate(this AppDbContext dbContext)
        {
            var migrate = dbContext.Database.GetInfrastructure().GetService<IMigrator>()
                ?? throw new InvalidOperationException("Unable to found migrator service.");

            foreach (var migrationName in dbContext.Database.GetPendingMigrations())
            {
                migrate.Migrate(migrationName);
            }
        }
    }
}
