namespace DataAccessLibrary.Configuration;

public class CountryConfiguration : IEntityTypeConfiguration<CountryModel>
{
    public void Configure(EntityTypeBuilder<CountryModel> builder)
    {
        builder.ToTable("Countries");
        builder.HasKey(e => e.CountryId);
        builder.HasMany(e => e.People)
            .WithOne(e => e.Country)
            .HasForeignKey(e => e.CountryId)
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction);
    }
}
