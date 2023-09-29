using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLibrary.Configuration
{
    public class AddressTypeConfiguration : IEntityTypeConfiguration<AddressTypeModel>
    {
        public void Configure(EntityTypeBuilder<AddressTypeModel> builder)
        {
            builder.ToTable("AddressTypes");
            builder.HasKey(e => e.AddressTypeId);
            builder.HasMany(e => e.Addresses)
                .WithOne(e => e.AddressType)
                .HasForeignKey(e => e.AddressTypeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
