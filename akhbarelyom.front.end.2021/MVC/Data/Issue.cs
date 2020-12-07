using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Issue
    {
        public int IssueId { get; set; }
        public string IssueTitle { get; set; }
        public DateTime? IssueDate { get; set; }
        public int IssueStatus { get; set; }
        public int JournalId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
