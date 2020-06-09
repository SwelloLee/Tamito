using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
    }
}