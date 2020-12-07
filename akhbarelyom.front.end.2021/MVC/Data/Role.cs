using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Role
    {
        public int NewId { get; set; }
        public string RoleName { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
