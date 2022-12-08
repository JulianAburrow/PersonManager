using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SavedUrlData : ISavedUrlData
    {
        private readonly PersonManagerContext _context;

        public SavedUrlData(PersonManagerContext context) =>
            _context = context;

        public async Task<SavedUrlModel> GetSavedUrl(int savedUrlId)
        {
            return await _context.SavedUrls
                .SingleOrDefaultAsync(m => m.UrlId == savedUrlId);
        }

        public async Task<List<SavedUrlModel>> GetSavedUrlModels()
        {
            return await _context.SavedUrls.ToListAsync();
        }

        public async Task InsertSavedUrl(SavedUrlModel savedUrl)
        {
            _context.SavedUrls.Add(savedUrl);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSavedUrl(SavedUrlModel savedUrl)
        {
            var oldSavedUrl = _context.SavedUrls
                .SingleOrDefault(s => s.UrlId == savedUrl.UrlId);
            if (oldSavedUrl == null) return;

            oldSavedUrl.Title = savedUrl.Title;
            oldSavedUrl.Url = savedUrl.Url;
            oldSavedUrl.Notes = savedUrl.Notes;
            oldSavedUrl.IsExternal = savedUrl.IsExternal;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteSavedUrl(int savedUrlId)
        {
            var savedUrl = _context.SavedUrls
                .SingleOrDefault(m => m.UrlId == savedUrlId);
            if (savedUrl == null) return;

            _context.SavedUrls.Remove(savedUrl);
            await _context.SaveChangesAsync();
        }
    }
}
