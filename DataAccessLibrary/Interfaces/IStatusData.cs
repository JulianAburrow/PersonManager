using DataAccessLibrary.Models;
using System.Collections.Generic;

namespace DataAccessLibrary.Interfaces
{
    public interface IStatusData
    {
        List<StatusModel> GetStatuses();
    }
}
