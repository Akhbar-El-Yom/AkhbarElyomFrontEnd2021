using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Umservice
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int? ModuleId { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string IconName { get; set; }
        public bool? ServiceHide { get; set; }
        public string RelatedService { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
