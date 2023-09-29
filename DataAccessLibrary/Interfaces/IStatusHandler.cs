namespace DataAccessLibrary.Interfaces;

public interface IStatusHandler
{
    Task<List<StatusModel>> GetStatuses();
}
