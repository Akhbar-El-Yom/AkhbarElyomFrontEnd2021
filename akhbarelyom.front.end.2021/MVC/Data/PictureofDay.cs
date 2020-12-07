using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class PictureofDay
    {
        public int PictureId { get; set; }
        public string PictureTitle { get; set; }
        public DateTime DateAdded { get; set; }
        public int JournalId { get; set; }
    }
}
