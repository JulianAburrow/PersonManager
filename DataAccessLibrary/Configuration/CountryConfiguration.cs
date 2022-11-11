using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLibrary.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<CountryModel>
    {
        public void Configure(EntityTypeBuilder<CountryModel> builder)
        {
            builder.Property(e => e.CountryName)
                .IsUnicode(false);
            builder.HasMany(e => e.People)
                .WithOne(e => e.Country)
                .HasForeignKey(e => e.CountryId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
