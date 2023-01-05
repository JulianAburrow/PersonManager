using System.Collections.Generic;

namespace DataAccessLibrary.Models
{
    public class StatusModel
    {
        public int  StatusId { get; set; }

        public string StatusName { get; set; }

        public ICollection<PersonModel> People { get; set; }
}
}
