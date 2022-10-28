using DataAccessLibrary.Configuration;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLibrary
{
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
        public DbSet<MyPersonManagerSavedUrlModel> MyPersonManagerSavedUrls { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AddressConfiguration());
            builder.ApplyConfiguration(new AddressTypeConfiguration());
            builder.ApplyConfiguration(new ColourConfiguration());
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new PersonConfiguration());
            builder.ApplyConfiguration(new StatusConfiguration());
        }
    }
}
