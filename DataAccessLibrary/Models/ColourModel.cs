namespace DataAccessLibrary.Models;

public class ColourModel
{
    public ColourModel() { }

    public ColourModel(string colourName)
    {
        ColourName = colourName;
    }

    public int ColourId { get; set; }

    public string ColourName { get; set; }

    public ICollection<PersonModel> People { get; set; } 
}
