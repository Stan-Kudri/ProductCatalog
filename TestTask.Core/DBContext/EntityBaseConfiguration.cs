using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTask.Core.Models;

namespace TestTask.Core.DBContext
{
    public abstract class EntityBaseConfiguration<T> : IEntityTypeConfiguration<T>
        where T : Entity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            ConfigureModel(builder);
        }

        protected abstract void ConfigureModel(EntityTypeBuilder<T> builder);
    }
}
