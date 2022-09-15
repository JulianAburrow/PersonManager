using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLibrary
{
    public class CountryData : ICountryData
    {
        private readonly PersonManagerContext _context;

        public CountryData(PersonManagerContext context) =>
            _context = context;

        public CountryModel GetCountry(int countryId)
        {
            return _context.Countries
                .Include(c => c.People)
                .SingleOrDefault(c => c.CountryId == countryId);
        }

        public List<CountryModel> GetCountries()
        {
            return _context.Countries
                .Include(c => c.People)
                .ToList();
        }

        public void InsertCountry(CountryModel country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
        }

        public void UpdateCountry(CountryModel country)
        {
            var oldCountry = _context.Countries
                .SingleOrDefault(c =>
                    c.CountryId == country.CountryId);
            if (oldCountry == null) return;

            oldCountry.CountryName = country.CountryName;

            _context.SaveChanges();
        }

        public void DeleteCountry(int countryId)
        {
            var country = _context.Countries
                .SingleOrDefault(c =>
                    c.CountryId == countryId);
            if (country == null) return;

            _context.Countries.Remove(country);
            _context.SaveChanges();
        }
    }
}
