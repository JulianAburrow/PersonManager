using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface IStatusData
    {
        Task<List<StatusModel>> GetStatuses();
    }
}
