using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLibrary
{
    public class ColourData : IColourData
    {
        private readonly PersonManagerContext _context;

        public ColourData(PersonManagerContext context) =>
            _context = context;

        public ColourModel GetColour(int colourId)
        {
            return _context.Colours
                .Include(c => c.People)
                .SingleOrDefault(c => c.ColourId == colourId);
        }

        public List<ColourModel> GetColours()
        {
            return _context.Colours
                .Include(c => c.People)
                .ToList();
        }

        public void InsertColour(ColourModel colour)
        {
            _context.Colours.Add(colour);
            _context.SaveChanges();
        }

        public void UpdateColour(ColourModel colour)
        {
            var oldColour = _context.Colours
                .SingleOrDefault(c =>
                    c.ColourId == colour.ColourId);
            if (oldColour == null) return;

            oldColour.ColourName = colour.ColourName;

            _context.SaveChanges();
        }

        public void DeleteColour(int colourId)
        {
            var colour = _context.Colours
                .SingleOrDefault(c =>
                    c.ColourId == colourId);
            if (colour == null) return;

            _context.Colours.Remove(colour);
            _context.SaveChanges();
        }
    }
}
