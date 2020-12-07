using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class NewsVideo
    {
        public int EntryId { get; set; }
        public int? NewsId { get; set; }
        public int? VideoId { get; set; }
    }
}
