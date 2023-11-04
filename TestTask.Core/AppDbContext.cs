using Microsoft.EntityFrameworkCore;
using TestTask.Core.Models.Company;
using TestTask.Core.Models.Steeps;
using TestTask.Core.Models.Users;

namespace TestTask.Core
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Company> Company { get; set; }

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

            var configurationCompany = modelBuilder.Entity<Company>();
            configurationCompany.ToTable("company");
            configurationCompany.HasKey(e => e.Id);
            configurationCompany.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            configurationCompany.Property(e => e.Name).IsRequired().HasMaxLength(128).HasColumnName("name").HasMaxLength(128);
            configurationCompany.Property(e => e.DateCreation).IsRequired().HasColumnType("DATETIME").HasColumnName("dateCreation");
            configurationCompany.Property(e => e.Country).IsRequired().HasMaxLength(64).HasColumnName("country");
            configurationCompany.HasMany(e => e.Product).WithOne().HasForeignKey(e => e.CompanyId);

            var configurationStep = modelBuilder.Entity<Step>();
            configurationStep.ToTable("step");
            configurationStep.HasKey(e => e.Id);
            configurationStep.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            configurationStep.Property(e => e.CompanyId).IsRequired().HasColumnName("modeId");
            configurationStep.Property(e => e.Timer).IsRequired().HasColumnName("timer");
            configurationStep.Property(e => e.Destination).HasColumnName("destination");
            configurationStep.Property(e => e.Speed).IsRequired().HasColumnName("speed");
            configurationStep.Property(e => e.Type).IsRequired().HasColumnName("type").HasMaxLength(128);
            configurationStep.Property(e => e.Volume).IsRequired().HasColumnName("volume");
        }
    }
}