using System;
using System.ComponentModel.DataAnnotations;
using BugTracker.Models;

namespace BugTracker.Models
{
    public class TicketModel
    {
        public Ticket Ticket { get; set; }
        public TicketUsers TicketUsers { get; set; }
        public Comment Comment { get; set; }

    }
}