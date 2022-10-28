using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLibrary.Models
{
    [Table("MyPersonManagerSavedUrls")]
    public class MyPersonManagerSavedUrlModel
    {
        [Key]
        public int UrlId { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public string Notes { get; set; }
    }
}
