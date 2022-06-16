using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CountryData : ICountryData
    {
        public ISqlDataAccess _db { get; }

        public CountryData(ISqlDataAccess db) =>
            _db = db;

        public Task<List<CountryModel>> GetCountries()
        {
            var sql = "select * from dbo.Countries";

            return _db.LoadData<CountryModel, dynamic>(sql, new { });
        }

        public Task InsertCountry(CountryModel country)
        {
            var sql = @"insert into dbo.Countries (CountryName)
                        values (@CountryName);";

            return _db.SaveData(sql, country);
        }

        public Task UpdateCountry(CountryModel country)
        {
            var sql = $@"update dbo.Countries set CountryName = {country.CountryName}
                        where CountryId = {country.CountryId}";

            return _db.SaveData(sql, country);
        }

        public Task<CountryModel> GetCountry(int countryId)
        {
            var sql = $"select * from Countries where CountryId = {countryId}";

            return _db.LoadSingle<CountryModel, dynamic>(sql, new { });
        }

        public Task DeleteCountry(int countryId)
        {
            var sql = $"delete from dbo.Countries where CountryId = {countryId}";

            return _db.DeleteData(sql);
        }
    }
}
