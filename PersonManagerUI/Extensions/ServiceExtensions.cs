namespace PersonManagerUI.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureSqlConnections(this IServiceCollection services, IConfiguration configuration) =>
        services.AddDbContext<PersonManagerContext>(
            options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("PersonManager")));

    public static void AddDependencies(this IServiceCollection services)
    {
        services.AddTransient<IPersonHandler, PersonHandler>();
        services.AddTransient<ICountryHandler, CountryHandler>();
        services.AddTransient<IStatusHandler, StatusHandler>();
        services.AddTransient<IColourHandler, ColourHandler>();
        services.AddTransient<IAddressHandler, AddressHandler>();
        services.AddTransient<IAddressTypeHandler, AddressTypeHandler>();
        services.AddTransient<ISavedUrlHandler, SavedUrlHandler>();
        services.AddTransient<IReminderHandler, ReminderHandler>();
    }
}
