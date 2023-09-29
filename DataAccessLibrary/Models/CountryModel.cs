namespace DataAccessLibrary.Models;

public class CountryModel
{
    public CountryModel() { }

    public CountryModel(string countryName)
    {
        CountryName = countryName;
    }

    public int CountryId { get; set; }

    public string CountryName { get; set; }

    public ICollection<PersonModel> People { get; set; }
}
