using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace PersonManagerTests
{
    public class CountryUnitTests
    {
        private readonly PersonManagerContext _personManagerContext;
        private readonly ICountryData _countryData;

        public CountryUnitTests()
        {
            var options = new DbContextOptionsBuilder<PersonManagerContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;
            _personManagerContext = new PersonManagerContext(options);
            _countryData = new CountryData(_personManagerContext);
        }

        readonly CountryModel country1 = new() { CountryName = "Bolivia", };
        readonly CountryModel country2 = new() { CountryName = "Peru", };
        readonly CountryModel country3 = new() { CountryName = "Guatemala", };

        [Fact]
        public async void AddCountryAddsCountry()
        {
            var initialCount = _personManagerContext.Countries.Count();

            await _countryData.InsertCountry(country1);
            await _countryData.InsertCountry(country2);
            await _countryData.InsertCountry(country3);
            _personManagerContext.SaveChanges();

            _personManagerContext.Countries.Count().Should().Be(initialCount + 3);
        }

        [Fact]
        public async void GetCountriesGetsCountries()
        {
            var initialCount = _personManagerContext.Countries.Count();

            await _countryData.InsertCountry(country1);
            await _countryData.InsertCountry(country2);
            await _countryData.InsertCountry(country3);
            _personManagerContext.SaveChanges();

            var currentCountries = await _countryData.GetCountries();
            currentCountries.Count().Should().Be(initialCount + 3);
        }

        [Fact]
        public async void DeleteCountryDeletesCountry()
        {
            var initialCount = _personManagerContext.Countries.Count();

            await _countryData.InsertCountry(country1);
            _personManagerContext.SaveChanges();
            await _countryData.DeleteCountry(country1.CountryId);
            _personManagerContext.SaveChanges();

            _personManagerContext.Countries.Count().Should().Be(initialCount);
        }

        [Fact]
        public async void GetCountryByIdGetsCountryById()
        {
            await _countryData.InsertCountry(country1);
            _personManagerContext.SaveChanges();
            var country = await _countryData.GetCountry(country1.CountryId);
            country.Should().Be(country1);
        }

        [Fact]
        public async void UpdateCountryUpdatesCountry()
        {
            var newCountryName = "Brazil";
            await _countryData.InsertCountry(country1);
            var country = await _countryData.GetCountry(country1.CountryId);
            country.CountryName = newCountryName;
            await _countryData.UpdateCountry(country);
            country = await _countryData.GetCountry(country1.CountryId);

            country.CountryName.Should().Be(newCountryName);
        }
    }
}
