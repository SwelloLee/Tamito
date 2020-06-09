using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class TicketHistory
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int TicketID { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
    }
}