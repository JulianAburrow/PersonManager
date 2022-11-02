using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLibrary
{
    public class SavedUrlData : ISavedUrlData
    {
        private readonly PersonManagerContext _context;

        public SavedUrlData(PersonManagerContext context) =>
            _context = context;

        public SavedUrlModel GetSavedUrl(int savedUrlId)
        {
            return _context.SavedUrls
                .SingleOrDefault(m => m.UrlId == savedUrlId);
        }

        public List<SavedUrlModel> GetSavedUrlModels()
        {
            return _context.SavedUrls.ToList();
        }

        public void InsertSavedUrl(SavedUrlModel savedUrl)
        {
            _context.SavedUrls.Add(savedUrl);
            _context.SaveChanges();
        }

        public void UpdateSavedUrl(SavedUrlModel savedUrl)
        {
            var oldSavedUrl = _context.SavedUrls
                .SingleOrDefault(s => s.UrlId == savedUrl.UrlId);
            if (oldSavedUrl == null) return;

            oldSavedUrl.Title = savedUrl.Title;
            oldSavedUrl.Url = savedUrl.Url;
            oldSavedUrl.Notes = savedUrl.Notes;
            oldSavedUrl.IsExternal = savedUrl.IsExternal;

            _context.SaveChanges();
        }

        public void DeleteSavedUrl(int savedUrlId)
        {
            var savedUrl = _context.SavedUrls
                .SingleOrDefault(m => m.UrlId == savedUrlId);
            if (savedUrl == null) return;

            _context.SavedUrls.Remove(savedUrl);
            _context.SaveChanges();
        }
    }
}
