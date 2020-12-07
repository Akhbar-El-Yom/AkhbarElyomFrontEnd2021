using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class NewsPoll
    {
        public int NewsId { get; set; }
        public int PollId { get; set; }

        public virtual Poll Poll { get; set; }
    }
}
