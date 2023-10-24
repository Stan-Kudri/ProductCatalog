using Microsoft.EntityFrameworkCore;

namespace TestTask.Core.Db
{
    public class FileDbContextFactory
    {
        public string _path;

        public FileDbContextFactory(string path) => _path = path;

        public AppDbContext Create()
        {
            var builder = new DbContextOptionsBuilder().UseSqlite($"Data Source={_path}");
            var dbContext = new AppDbContext(builder.Options);
            dbContext.Database.EnsureCreated();
            return dbContext;
        }
    }
}
