using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class NewsBlock
    {
        public int BlockId { get; set; }
        public string BlockName { get; set; }
        public string BlockText { get; set; }
        public int? JournalId { get; set; }
        public int? ZoneId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
