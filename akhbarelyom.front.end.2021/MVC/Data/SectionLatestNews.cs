using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class SectionLatestNews
    {
        public int NewId { get; set; }
        public string Title { get; set; }
        public string Brief { get; set; }
        public string PictureName { get; set; }
        public string PictureCaption1 { get; set; }
        public DateTime? PublishDate { get; set; }
        public string SecTitle { get; set; }
        public byte? WeeklySection { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
