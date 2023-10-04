namespace DataAccessLibrary.Models;

public class CountryModel
{
    public int CountryId { get; set; }

    public string CountryName { get; set; }

    public ICollection<PersonModel> People { get; set; }
}
