using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class MyPersonManagerSavedUrlData : IMyPersonManagerSavedUrlData
    {
        private readonly PersonManagerContext _context;

        public MyPersonManagerSavedUrlData(PersonManagerContext context) =>
            _context = context;

        public MyPersonManagerSavedUrlModel GetMyPersonManagerSavedUrl(int myPersonManagerSavedUrlId)
        {
            return _context.MyPersonManagerSavedUrls
                .SingleOrDefault(m => m.UrlId == myPersonManagerSavedUrlId);
        }

        public List<MyPersonManagerSavedUrlModel> GetMyPersonManagerSavedUrlModels()
        {
            return _context.MyPersonManagerSavedUrls.ToList();
        }

        public void InsertMyPersonManagerSavedUrl(MyPersonManagerSavedUrlModel myPersonManagerSavedUrl)
        {
            _context.MyPersonManagerSavedUrls.Add(myPersonManagerSavedUrl);
            _context.SaveChanges();
        }

        public void DeleteMyPersonManagerSavedUrl(int myPersonManagerSavedUrlId)
        {
            var myPersonManagerSavedUrl = _context.MyPersonManagerSavedUrls
                .SingleOrDefault(m => m.UrlId == myPersonManagerSavedUrlId);
            if (myPersonManagerSavedUrl == null) return;

            _context.MyPersonManagerSavedUrls.Remove(myPersonManagerSavedUrl);
            _context.SaveChanges();
        }
    }
}
