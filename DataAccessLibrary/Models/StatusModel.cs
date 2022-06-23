using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLibrary.Models
{
    [Table("Statuses")]
    public class StatusModel
    {
        [Key]
        public int  StatusId { get; set; }

        public string StatusName { get; set; }

        public ICollection<PersonModel> People { get; set; }
}
}
