using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int TypeID { get; set; }
        public string CommentType { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
    }
}