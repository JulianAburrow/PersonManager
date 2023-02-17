

using DataAccessLibrary.Models;

namespace PersonManagerTests
{
    [TestClass]
    public class CountryUnitTests
    {
        private readonly PersonManagerContext _context;

        public CountryUnitTests(PersonManagerContext context)
        { 
            _context = context;
        }
            

        // Needs refining to account for no countries returned
        [TestMethod]
        public void GetCountryReturnsACountryWhenValidIdIsProvided()
        {
            // Arrange
            var firstCountry = _context.Countries.First();
            var cd = new CountryData(_context);

            // Act
            var country = cd.GetCountry(firstCountry.CountryId);
            
            // Assert
            Assert.IsTrue(country != null);
        }

        [TestMethod]
        public async Task GetCountryDoesNotReturnACountryWhenInvalidIdIsProvided()
        {
            // Arrange
            var cd = new CountryData(_context);

            // Act
            var country = await cd.GetCountry(1000000);

            // Assert
            Assert.IsTrue(country == null);
        }

        [TestMethod]
        public async Task GetCountriesReturnsAllCountries()
        {
            // Arrange
            var cd = new CountryData(_context);
            var countryCount = _context.Countries.Count();

            // Act
            var allCountries = await cd.GetCountries();

            // Assert
            Assert.IsTrue(countryCount == allCountries.Count);
        }

    //    [TestMethod]
    //    public async Task AddCountryAddsCountry()
    //    {
    //        // Arrange
    //        var cd = new CountryData(_context);
    //        var newCountry = new CountryModel
    //        {
    //            CountryName = "TestCountry"
    //        };


    //        // Act


    //        // Assert
    }
}