using System.Dynamic;
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

        public DbSet<PersonModel> People { get; set; }
        public DbSet<CountryModel> Countries { get; set; }
        public DbSet<StatusModel> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PersonConfiguration());
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new StatusConfiguration());
        }
    }
}
