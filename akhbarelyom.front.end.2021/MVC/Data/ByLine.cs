using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class ByLine
    {
        public int ByLineId { get; set; }
        public string ByLineName { get; set; }
        public bool? Active { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
