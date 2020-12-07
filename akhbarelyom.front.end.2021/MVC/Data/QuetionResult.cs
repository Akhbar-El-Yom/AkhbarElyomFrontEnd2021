using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class QuetionResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public int? IdQuetion { get; set; }
        public int? ResultEgypt { get; set; }
        public int? ResultOther { get; set; }
        public string Success { get; set; }
    }
}
