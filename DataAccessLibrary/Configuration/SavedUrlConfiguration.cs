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
        }
    }
}
