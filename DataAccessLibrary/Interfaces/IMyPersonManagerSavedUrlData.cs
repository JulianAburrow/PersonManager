using DataAccessLibrary.Models;
using System.Collections.Generic;

namespace DataAccessLibrary.Interfaces
{
    public interface IMyPersonManagerSavedUrlData
    {
        MyPersonManagerSavedUrlModel GetMyPersonManagerSavedUrl(int myPersonManagerSavedUrlId);

        List<MyPersonManagerSavedUrlModel> GetMyPersonManagerSavedUrlModels();

        void InsertMyPersonManagerSavedUrl(MyPersonManagerSavedUrlModel myPersonManagerSavedUrl);

        void DeleteMyPersonManagerSavedUrl(int myPersonManagerSavedUrlId);
    }
}
