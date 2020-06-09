using System;
using System.ComponentModel.DataAnnotations;
using BugTracker.Models;

namespace BugTracker.Models
{
    public class ProjectModel
    {
        public Project Project { get; set; }
        public ProjectUsers ProjectUsers { get; set; }
        public Comment Comment { get; set; }

    }
}