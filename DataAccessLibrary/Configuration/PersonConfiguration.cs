namespace DataAccessLibrary.Configuration;

public class PersonConfiguration : IEntityTypeConfiguration<PersonModel>
{
    public void Configure(EntityTypeBuilder<PersonModel> builder)
    {
        builder.ToTable("People");
        builder.HasKey(e => e.PersonId);
        builder.HasOne(e => e.Country)
            .WithMany(e => e.People)
            .HasForeignKey(e => e.CountryId)
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(e => e.Status)
            .WithMany(e => e.People)
            .HasForeignKey(e => e.StatusId)
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(e => e.FavouriteColour)
            .WithMany(e => e.People)
            .HasForeignKey(e => e.FavouriteColourId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(e => e.Address)
            .WithOne(e => e.Person)
            .HasForeignKey<PersonModel>(e => e.AddressId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
