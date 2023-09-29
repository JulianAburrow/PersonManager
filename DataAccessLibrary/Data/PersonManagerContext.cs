namespace DataAccessLibrary.Data;

public class PersonManagerContext : DbContext
{
    public PersonManagerContext(DbContextOptions<PersonManagerContext> options)
        : base(options)
    {
    }

    public DbSet<AddressModel> Addresses { get; set; }
    public DbSet<AddressTypeModel> AddressTypes { get; set; }
    public DbSet<ColourModel> Colours { get; set; }
    public DbSet<CountryModel> Countries { get; set; }
    public DbSet<PersonModel> People { get; set; }
    public DbSet<StatusModel> Statuses { get; set; }

    // MyPersonManager objects
    public DbSet<SavedUrlModel> SavedUrls { get; set; }
    public DbSet<ReminderModel> Reminders { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        foreach (var property in builder.Model.GetEntityTypes()
            .SelectMany(e => e.GetProperties()
            .Where(p => p.ClrType == typeof(string))))
        {
            property.SetIsUnicode(false);
        }

        builder.ApplyConfiguration(new AddressConfiguration());
        builder.ApplyConfiguration(new AddressTypeConfiguration());
        builder.ApplyConfiguration(new ColourConfiguration());
        builder.ApplyConfiguration(new CountryConfiguration());
        builder.ApplyConfiguration(new PersonConfiguration());
        builder.ApplyConfiguration(new ReminderConfiguration());
        builder.ApplyConfiguration(new SavedUrlConfiguration());
        builder.ApplyConfiguration(new StatusConfiguration());
    }
}
