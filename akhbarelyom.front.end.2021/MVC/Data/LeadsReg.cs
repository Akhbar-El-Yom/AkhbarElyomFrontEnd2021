using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class LeadsReg
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public int? Lead { get; set; }
        public DateTime? DateReg { get; set; }
    }
}
