using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string EmplyeeName { get; set; }
        public int? Displayorder { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
