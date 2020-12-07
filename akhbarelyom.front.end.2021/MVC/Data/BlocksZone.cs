using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class BlocksZone
    {
        public int ZoneId { get; set; }
        public string ZoneName { get; set; }
        public string ZoneDescription { get; set; }
        public DateTime? AddedDate { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
