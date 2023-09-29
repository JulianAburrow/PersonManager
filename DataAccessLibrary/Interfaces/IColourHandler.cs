namespace DataAccessLibrary.Interfaces;

public interface IColourHandler
{
    Task<ColourModel> GetColour(int colourId);

    Task<List<ColourModel>> GetColours();

    Task InsertColour(ColourModel colour);

    Task UpdateColour(ColourModel colour);

    Task DeleteColour(int colourId);
}
