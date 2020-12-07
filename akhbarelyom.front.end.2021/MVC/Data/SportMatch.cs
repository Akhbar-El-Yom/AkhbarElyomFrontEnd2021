using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class SportMatch
    {
        public int Id { get; set; }
        public DateTime? Dat { get; set; }
        public int? Team1 { get; set; }
        public int? Team2 { get; set; }
        public int? Flag1 { get; set; }
        public int? Flag2 { get; set; }
        public int? Mal3bId { get; set; }
        public string StadName { get; set; }
        public string Groups { get; set; }
        public string LinkNews { get; set; }
        public int? ResultTeam1 { get; set; }
        public int? ResultTeam2 { get; set; }
        public string LiveEnd { get; set; }
    }
}
