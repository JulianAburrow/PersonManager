using DataAccessLibrary.Models;
using System.Collections.Generic;

namespace DataAccessLibrary.Interfaces
{
    public interface IStatusesData
    {
        List<StatusModel> GetStatuses();
    }
}
