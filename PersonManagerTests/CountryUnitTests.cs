using DataAccessLibrary.Data;
using DataAccessLibrary.Handlers;

namespace PersonManagerTests
{
    public class CountryUnitTests
    {
        private readonly PersonManagerContext _personManagerContext;
        private readonly ICountryHandler _countryData;

        public CountryUnitTests()
        {
            var options = new DbContextOptionsBuilder<PersonManagerContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;
            _personManagerContext = new PersonManagerContext(options);
            _countryData = new CountryHandler(_personManagerContext);
        }

        private readonly CountryModel country1 = new() { CountryName = "Bolivia", };
        private readonly CountryModel country2 = new() { CountryName = "Peru", };
        private readonly CountryModel country3 = new() { CountryName = "Guatemala", };

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

            _personManagerContext.Countries.Add(country1);
            _personManagerContext.Countries.Add(country2);
            _personManagerContext.Countries.Add(country3);
            _personManagerContext.SaveChanges();

            var currentCountries = await _countryData.GetCountries();
            currentCountries.Count.Should().Be(initialCount + 3);
        }

        [Fact]
        public async void DeleteCountryDeletesCountry()
        {
            var initialCount = _personManagerContext.Countries.Count();

            _personManagerContext.Countries.Add(country1);
            _personManagerContext.SaveChanges();
            await _countryData.DeleteCountry(country1.CountryId);
            _personManagerContext.SaveChanges();

            _personManagerContext.Countries.Count().Should().Be(initialCount);
        }

        [Fact]
        public async void GetCountryByIdGetsCountryById()
        {
            _personManagerContext.Countries.Add(country1);
            _personManagerContext.SaveChanges();
            var country = await _countryData.GetCountry(country1.CountryId);
            country.Should().Be(country1);
        }

        [Fact]
        public async void UpdateCountryUpdatesCountry()
        {
            var newCountryName = "Brazil";
            _personManagerContext.Countries.Add(country1);
            _personManagerContext.SaveChanges();
            var country = _personManagerContext.Countries.Single(c => c.CountryId == country1.CountryId);
            country.CountryName = newCountryName;
            await _countryData.UpdateCountry(country);
            _personManagerContext.SaveChanges();
            country = _personManagerContext.Countries.Single(c => c.CountryId == country1.CountryId);

            country.CountryName.Should().Be(newCountryName);
        }
    }
}
