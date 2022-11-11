using DataAccessLibrary.Models;
using System.Collections.Generic;

namespace DataAccessLibrary.Interfaces
{
    public interface IColourData
    {
        ColourModel GetColour(int colourId);

        List<ColourModel> GetColours();

        void InsertColour(ColourModel colour);

        void UpdateColour(ColourModel colour);

        void DeleteColour(int colourId);
    }
}
