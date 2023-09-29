namespace DataAccessLibrary.Handlers;

public class ColourHandler : IColourHandler
{
    private readonly PersonManagerContext _context;

    public ColourHandler(PersonManagerContext context) =>
        _context = context;

    public async Task<ColourModel> GetColour(int colourId)
    {
        return await _context.Colours
            .Include(c => c.People)
            .SingleOrDefaultAsync(c => c.ColourId == colourId);
    }

    public async Task<List<ColourModel>> GetColours()
    {
        return await _context.Colours
            .Include(c => c.People)
            .OrderBy(c => c.ColourName)
            .ToListAsync();
    }

    public async Task InsertColour(ColourModel colour)
    {
        _context.Colours.Add(colour);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateColour(ColourModel colour)
    {
        var oldColour = _context.Colours
            .SingleOrDefault(c =>
                c.ColourId == colour.ColourId);
        if (oldColour == null) return;

        oldColour.ColourName = colour.ColourName;

        await _context.SaveChangesAsync();
    }

    public async Task DeleteColour(int colourId)
    {
        var colour = _context.Colours
            .SingleOrDefault(c =>
                c.ColourId == colourId);
        if (colour == null) return;

        _context.Colours.Remove(colour);
        await _context.SaveChangesAsync();
    }
}
