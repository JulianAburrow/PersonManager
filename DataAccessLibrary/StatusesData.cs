using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLibrary
{
    public class StatusesData : IStatusesData
    {
        private readonly PersonManagerContext _context;

        public StatusesData(PersonManagerContext context) =>
            _context = context;

        public List<StatusModel> GetStatuses()
        {
            return _context.Statuses.ToList();
        }
    }
}
