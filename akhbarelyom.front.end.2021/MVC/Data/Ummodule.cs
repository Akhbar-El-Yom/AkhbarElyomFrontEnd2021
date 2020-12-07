using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Ummodule
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string AreaName { get; set; }
        public string IconName { get; set; }
        public bool? ModuleHide { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
