using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class File
    {
        public int Id { get; set; }
        public string PicName { get; set; }
        public string Url { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
