using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class VTopNewsToday
    {
        public int? Views { get; set; }
        public string PublishDate { get; set; }
        public string Brief { get; set; }
        public string Title { get; set; }
        public string PictureName { get; set; }
        public int NewId { get; set; }
        public string SubTitle { get; set; }
    }
}
