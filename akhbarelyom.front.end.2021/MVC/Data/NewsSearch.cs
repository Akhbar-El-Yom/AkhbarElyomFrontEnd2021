using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class NewsSearch
    {
        public int NewId { get; set; }
        public string Title { get; set; }
        public string Byline { get; set; }
        public string Brief { get; set; }
        public int SectionId { get; set; }
        public string Title2 { get; set; }
        public string Brief2 { get; set; }
        public string Byline2 { get; set; }
    }
}
