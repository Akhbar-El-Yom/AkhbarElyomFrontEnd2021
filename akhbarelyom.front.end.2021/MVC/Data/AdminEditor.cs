using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class AdminEditor
    {
        public int EditorId { get; set; }
        public string EditorName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public int? Pic { get; set; }
        public int DisplayOrder { get; set; }
        public int Type { get; set; }
    }
}
