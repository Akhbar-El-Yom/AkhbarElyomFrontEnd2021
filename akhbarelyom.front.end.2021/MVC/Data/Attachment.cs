using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Attachment
    {
        public int FileId { get; set; }
        public int? NewId { get; set; }
        public string Discription { get; set; }
        public string FileName { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
