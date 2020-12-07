using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class VuserPermission
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        public int RoleId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string FullName { get; set; }
        public string AreaName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string ServiceIcon { get; set; }
        public string ModuleIcon { get; set; }
        public bool? ModuleHide { get; set; }
        public bool? ServiceHide { get; set; }
    }
}
