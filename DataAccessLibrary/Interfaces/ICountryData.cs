using DataAccessLibrary.Models;
using System.Collections.Generic;

namespace DataAccessLibrary.Interfaces
{
    public interface ICountryData
    {
        CountryModel GetCountry(int countryId);

        List<CountryModel> GetCountries();

        void InsertCountry(CountryModel country);

        void UpdateCountry(CountryModel country);

        void DeleteCountry(int countryId);
    }
}
