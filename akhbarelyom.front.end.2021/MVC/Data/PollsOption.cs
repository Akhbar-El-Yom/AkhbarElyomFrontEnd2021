using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class PollsOption
    {
        public int OptionId { get; set; }
        public int? PollId { get; set; }
        public string OptionBody { get; set; }
        public int? Votes { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Poll Poll { get; set; }
    }
}
