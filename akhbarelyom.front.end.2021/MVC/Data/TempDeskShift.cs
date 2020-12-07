using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class TempDeskShift
    {
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public bool? AssignFlag { get; set; }
        public bool? WaitingFlag { get; set; }
    }
}
