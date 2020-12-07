using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class GalleryType
    {
        public int GalleryTypeId { get; set; }
        public string GalleryTypeName { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
