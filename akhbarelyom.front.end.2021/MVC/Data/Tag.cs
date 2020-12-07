using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Tag
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatioDate { get; set; }
    }
}
