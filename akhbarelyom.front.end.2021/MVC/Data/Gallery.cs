using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Gallery
    {
        public int GalleryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public DateTime? Gdate { get; set; }
        public int? MainPictureId { get; set; }
        public bool? IsHome { get; set; }
        public string GalleryType { get; set; }
        public int? JournalId { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
