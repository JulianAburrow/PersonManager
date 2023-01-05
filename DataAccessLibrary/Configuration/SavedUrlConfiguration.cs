using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLibrary.Configuration
{
    public class SavedUrlConfiguration : IEntityTypeConfiguration<SavedUrlModel>
    {
        public void Configure(EntityTypeBuilder<SavedUrlModel> builder)
        {
            builder.ToTable("SavedUrls");
            builder.HasKey(e => e.UrlId);
            builder.Property(e => e.Title)
                .IsUnicode(false);
            builder.Property(e => e.Url)
                .IsUnicode(false);
            builder.Property(e => e.Notes)
                .IsUnicode(false);
        }
    }
}
