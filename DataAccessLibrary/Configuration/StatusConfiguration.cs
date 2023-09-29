using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLibrary.Configuration
{
    public class StatusConfiguration : IEntityTypeConfiguration<StatusModel>
    {
        public void Configure(EntityTypeBuilder<StatusModel> builder)
        {
            builder.ToTable("Statuses");
            builder.HasKey(e => e.StatusId);
            builder.HasMany(e => e.People)
                .WithOne(e => e.Status)
                .HasForeignKey(e => e.StatusId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
