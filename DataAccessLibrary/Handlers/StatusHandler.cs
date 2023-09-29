namespace DataAccessLibrary.Handlers;

public class StatusHandler : IStatusHandler
{
    private readonly PersonManagerContext _context;

    public StatusHandler(PersonManagerContext context) =>
        _context = context;

    public Task<List<StatusModel>> GetStatuses()
    {
        return _context.Statuses.ToListAsync();
    }
}
