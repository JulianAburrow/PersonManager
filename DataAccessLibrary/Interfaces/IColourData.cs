using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLibrary.Models;

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
