using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BugTracker.Models.Comment> Comment { get; set; }
        public DbSet<BugTracker.Models.Project> Project { get; set; }
        public DbSet<BugTracker.Models.ProjectUsers> ProjectUsers { get; set; }
        public DbSet<BugTracker.Models.Ticket> Ticket { get; set; }
        public DbSet<BugTracker.Models.TicketUsers> TicketUsers { get; set; }
        public DbSet<BugTracker.Models.ProjectHistory> ProjectHistory { get; set; }
        public DbSet<BugTracker.Models.TicketHistory> TicketHistory { get; set; }
    }
}
