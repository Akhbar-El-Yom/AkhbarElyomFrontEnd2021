using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class GalleryPicture
    {
        public int GalleryId { get; set; }
        public int PictureId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
