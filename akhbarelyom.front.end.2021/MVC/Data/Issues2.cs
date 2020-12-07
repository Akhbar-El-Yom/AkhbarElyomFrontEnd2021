using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Issues2
    {
        public int IssueId { get; set; }
        public string IssueTitle { get; set; }
        public DateTime? IssueDate { get; set; }
        public int? IssueStatus { get; set; }
        public int? JournalId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Journalname { get; set; }
        public int? Issuenumber { get; set; }
        public string Cover { get; set; }
        public string Url { get; set; }
        public int? Orderissu { get; set; }
        public string Addby { get; set; }
        public int? Active { get; set; }
        public string Cover2 { get; set; }
    }
}
