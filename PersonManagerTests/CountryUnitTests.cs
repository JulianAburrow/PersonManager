namespace PersonManagerTests
{
    [TestClass]
    public class CountryUnitTests
    {
        private readonly PersonManagerContext _context;

        public CountryUnitTests(PersonManagerContext context) =>
            _context = context;

        // Needs refining to account for no countries returned
        [TestMethod]
        public async Task GetCountryReturnsACountryWhenValidIdIsProvided()
        {
            // Arrange
            var cd = new CountryData(_context);
            var countries = await cd.GetCountries();
            var firstCountry = countries.First();

            // Act
            var country = cd.GetCountry(firstCountry.CountryId);
            

            // Assert
            Assert.IsTrue(country != null);
        }
    }
}