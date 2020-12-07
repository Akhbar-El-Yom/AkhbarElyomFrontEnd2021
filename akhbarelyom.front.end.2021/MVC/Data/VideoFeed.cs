using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class VideoFeed
    {
        public int EntryId { get; set; }
        public string Title { get; set; }
        public string Brief { get; set; }
        public string Link { get; set; }
        public string Type { get; set; }
        public DateTime? Date { get; set; }
        public string Thumb { get; set; }
        public string TitleAr { get; set; }
        public string BriefAr { get; set; }
        public string TypeAr { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
