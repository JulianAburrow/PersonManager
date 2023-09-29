namespace DataAccessLibrary.Interfaces;

public interface ICountryHandler
{
    Task<CountryModel> GetCountry(int countryId);

    Task <List<CountryModel>> GetCountries();

    Task InsertCountry(CountryModel country);

    Task UpdateCountry(CountryModel country);

    Task DeleteCountry(int countryId);
}
