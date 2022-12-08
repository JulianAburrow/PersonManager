using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface ICountryData
    {
        Task<CountryModel> GetCountry(int countryId);

        List<CountryModel> GetCountries();

        void InsertCountry(CountryModel country);

        void UpdateCountry(CountryModel country);

        void DeleteCountry(int countryId);
    }
}
