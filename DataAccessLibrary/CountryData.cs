using DataAccessLibrary.Data;
using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CountryData : ICountryData
    {
        private readonly PersonManagerContext _context;

        public CountryData(PersonManagerContext context) =>
            _context = context;

        public async Task<CountryModel> GetCountry(int countryId)
        {
            return await _context.Countries
                        .Include(c => c.People)
                        .SingleOrDefaultAsync(c => c.CountryId == countryId);
        }

        public async Task<List<CountryModel>> GetCountries()
        {
            return await _context.Countries
                .Include(c => c.People)
                .OrderBy(c => c.CountryName)
                .ToListAsync();
        }

        public async Task InsertCountry(CountryModel country)
        {
            _context.Countries.Add(country);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCountry(CountryModel country)
        {
            var oldCountry = _context.Countries
                .SingleOrDefault(c =>
                    c.CountryId == country.CountryId);
            if (oldCountry == null) return;

            oldCountry.CountryName = country.CountryName;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteCountry(int countryId)
        {
            var country = _context.Countries
                .SingleOrDefault(c =>
                    c.CountryId == countryId);
            if (country == null) return;

            _context.Countries.Remove(country);
            await _context.SaveChangesAsync();
        }
    }
}
