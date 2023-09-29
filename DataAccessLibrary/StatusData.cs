using DataAccessLibrary.Data;
using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class StatusData : IStatusData
    {
        private readonly PersonManagerContext _context;

        public StatusData(PersonManagerContext context) =>
            _context = context;

        public Task<List<StatusModel>> GetStatuses()
        {
            return _context.Statuses.ToListAsync();
        }
    }
}
