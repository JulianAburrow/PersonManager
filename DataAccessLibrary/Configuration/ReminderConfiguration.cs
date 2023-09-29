namespace DataAccessLibrary.Configuration;

public class ReminderConfiguration : IEntityTypeConfiguration<ReminderModel>
{
    public void Configure(EntityTypeBuilder<ReminderModel> builder)
    {
        builder.ToTable("Reminders");
        builder.HasKey(e => e.ReminderId);
    }
}
