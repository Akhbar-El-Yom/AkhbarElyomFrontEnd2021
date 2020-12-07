using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class ComicsofDay
    {
        public int PictureId { get; set; }
        public string PictureTitle { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
