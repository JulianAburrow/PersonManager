namespace DataAccessLibrary.Interfaces;

public interface ISavedUrlHandler
{
    Task<SavedUrlModel> GetSavedUrl(int savedUrlId);

    Task<List<SavedUrlModel>> GetSavedUrlModels();

    Task InsertSavedUrl(SavedUrlModel savedUrl);

    Task UpdateSavedUrl(SavedUrlModel savedUrl);

    Task DeleteSavedUrl(int savedUrlId);
}
