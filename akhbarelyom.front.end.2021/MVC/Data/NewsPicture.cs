using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class NewsPicture
    {
        public int PictureId { get; set; }
        public string PictureName { get; set; }
        public string KeyWords { get; set; }
        public string PicCaption { get; set; }
        public int? CatId { get; set; }
        public DateTime? AddedDate { get; set; }
        public byte? Source { get; set; }
        public int? JournalId { get; set; }
    }
}
