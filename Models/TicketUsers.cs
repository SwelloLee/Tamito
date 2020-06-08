using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class TicketUsers
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int TicketID { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
    }
}