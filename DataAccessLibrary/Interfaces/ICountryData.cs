using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface ICountryData
    {
        Task<CountryModel> GetCountry(int countryId);

        Task <List<CountryModel>> GetCountries();

        Task InsertCountry(CountryModel country);

        Task UpdateCountry(CountryModel country);

        Task DeleteCountry(int countryId);
    }
}
