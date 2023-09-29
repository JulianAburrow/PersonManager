using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLibrary.Configuration
{
    public class ColourConfiguration : IEntityTypeConfiguration<ColourModel>
    {
        public void Configure(EntityTypeBuilder<ColourModel> builder)
        {
            builder.ToTable("Colours");
            builder.HasKey(e => e.ColourId);
            builder.HasMany(e => e.People)
                .WithOne(e => e.FavouriteColour)
                .HasForeignKey(e => e.FavouriteColourId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
