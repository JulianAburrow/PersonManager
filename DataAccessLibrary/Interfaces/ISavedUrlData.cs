using DataAccessLibrary.Models;
using System.Collections.Generic;

namespace DataAccessLibrary.Interfaces
{
    public interface ISavedUrlData
    {
        SavedUrlModel GetSavedUrl(int savedUrlId);

        List<SavedUrlModel> GetSavedUrlModels();

        void InsertSavedUrl(SavedUrlModel savedUrl);

        void UpdateSavedUrl(SavedUrlModel savedUrl);

        void DeleteSavedUrl(int savedUrlId);
    }
}
