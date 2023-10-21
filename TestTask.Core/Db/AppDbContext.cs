using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using TestTask.Core.Components;

namespace TestTask.Core.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(string connectionString)
            : base(connectionString)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var configuration = modelBuilder.Entity<User>();
            configuration.ToTable("User");
            configuration.HasKey(e => e.Id);
            configuration.Property(e => e.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            configuration.Property(e => e.Username).IsRequired().HasColumnName("Username").HasMaxLength(128);
            configuration.Property(e => e.PasswordHash).IsRequired().HasColumnName("PasswordHash").HasMaxLength(128);
        }
    }
}