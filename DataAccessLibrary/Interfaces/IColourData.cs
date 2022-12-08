using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface IColourData
    {
        Task<ColourModel> GetColour(int colourId);

        Task<List<ColourModel>> GetColours();

        Task InsertColour(ColourModel colour);

        Task UpdateColour(ColourModel colour);

        Task DeleteColour(int colourId);
    }
}
