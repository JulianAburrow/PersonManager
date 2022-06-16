using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface ICountryData
    {
        Task<List<CountryModel>> GetCountries();

        Task InsertCountry(CountryModel country);

        Task UpdateCountry(CountryModel country);

        Task<CountryModel> GetCountry(int countryId);

        Task DeleteCountry(int countryId);
    }
}
