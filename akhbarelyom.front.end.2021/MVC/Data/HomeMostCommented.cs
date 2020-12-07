using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class HomeMostCommented
    {
        public int NewId { get; set; }
        public string Title { get; set; }
        public int? Comments { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
