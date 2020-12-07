using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Trend
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? TagId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
