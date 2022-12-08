using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface ISavedUrlData
    {
        Task<SavedUrlModel> GetSavedUrl(int savedUrlId);

        Task<List<SavedUrlModel>> GetSavedUrlModels();

        Task InsertSavedUrl(SavedUrlModel savedUrl);

        Task UpdateSavedUrl(SavedUrlModel savedUrl);

        Task DeleteSavedUrl(int savedUrlId);
    }
}
