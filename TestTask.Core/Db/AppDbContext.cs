using Microsoft.EntityFrameworkCore;
using TestTask.Core.Components;
using TestTask.Core.Components.ItemsTables;

namespace TestTask.Core.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Mode> Modes { get; set; }

        public DbSet<Step> Steps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var configurationUser = modelBuilder.Entity<User>();
            configurationUser.ToTable("user");
            configurationUser.HasKey(e => e.Id);
            configurationUser.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            configurationUser.HasIndex(e => e.Username).IsUnique();
            configurationUser.Property(e => e.Username).IsRequired().HasColumnName("username").HasMaxLength(128);
            configurationUser.Property(e => e.PasswordHash).IsRequired().HasColumnName("passwordHash").HasMaxLength(128);

            var configurationMode = modelBuilder.Entity<Mode>();
            configurationMode.ToTable("mode");
            configurationMode.HasKey(e => e.Id);
            configurationMode.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            configurationMode.Property(e => e.Name).IsRequired().HasColumnName("name").HasMaxLength(128);
            configurationMode.Property(e => e.MaxBottleNumber).IsRequired().HasColumnName("maxBottleNumber");
            configurationMode.Property(e => e.MaxUsedTips).IsRequired().HasColumnName("maxUsedTips");
            configurationMode.HasMany(e => e.Steps).WithOne().HasForeignKey(e => e.ModeId);

            var configurationStep = modelBuilder.Entity<Step>();
            configurationStep.ToTable("step");
            configurationStep.HasKey(e => e.Id);
            configurationStep.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            configurationStep.Property(e => e.ModeId).IsRequired().HasColumnName("modeId");
            configurationStep.Property(e => e.Timer).IsRequired().HasColumnName("timer");
            configurationStep.Property(e => e.Destination).HasColumnName("destination");
            configurationStep.Property(e => e.Speed).IsRequired().HasColumnName("speed");
            configurationStep.Property(e => e.Type).IsRequired().HasColumnName("type").HasMaxLength(128);
            configurationStep.Property(e => e.Volume).IsRequired().HasColumnName("volume");
        }
    }
}