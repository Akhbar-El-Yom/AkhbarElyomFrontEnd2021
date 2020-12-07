using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class NewsTicker
    {
        public int NewId { get; set; }
        public string Title { get; set; }
        public int? NewsId { get; set; }
        public DateTime? AddedDate { get; set; }
        public int? JournalId { get; set; }
        public int? SectionId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
