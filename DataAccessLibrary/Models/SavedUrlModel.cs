namespace DataAccessLibrary.Models
{
    public class SavedUrlModel
    {
        public int UrlId { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public string Notes { get; set; }

        public bool IsExternal { get; set; }
    }
}
