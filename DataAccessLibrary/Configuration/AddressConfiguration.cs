using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLibrary.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<AddressModel>
    {
        public void Configure(EntityTypeBuilder<AddressModel> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(e => e.AddressId);
            builder.Property(e => e.AddressLine1)
                .IsUnicode(false);
            builder.Property(e => e.AddressLine2)
                .IsUnicode(false);
            builder.Property(e => e.Town)
                .IsUnicode(false);
            builder.Property(e => e.Postcode)
                .IsUnicode(false);
            builder.HasOne(e => e.AddressType)
                .WithMany(e => e.Addresses)
                .HasForeignKey(e => e.AddressId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.Person)
                .WithOne(e => e.Address)
                .HasForeignKey<AddressModel>(e => e.AddressId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
