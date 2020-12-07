using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Journal
    {
        public int JournalId { get; set; }
        public string Name { get; set; }
        public string Cover { get; set; }
        public string Fbtoken { get; set; }
        public string ImageLargeSize { get; set; }
        public string ImageSmallSize { get; set; }
        public string ImageSliderSize { get; set; }
        public string ComicLargeSize { get; set; }
        public string ComicSmallSize { get; set; }
        public string EditorLargeSize { get; set; }
        public string EditorSmallSize { get; set; }
        public string PainterLargeSize { get; set; }
        public string PainterSmallSize { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
