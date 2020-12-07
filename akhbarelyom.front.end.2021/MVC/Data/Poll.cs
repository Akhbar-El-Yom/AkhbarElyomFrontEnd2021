using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Poll
    {
        public Poll()
        {
            NewsPolls = new HashSet<NewsPoll>();
            PollsOptions = new HashSet<PollsOption>();
        }

        public int PollId { get; set; }
        public int SectionId { get; set; }
        public string PollBody { get; set; }
        public DateTime? AddedDate { get; set; }
        public byte? Activated { get; set; }
        public DateTime? DateActivated { get; set; }
        public int? TotalVotes { get; set; }
        public int? JournalId { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual ICollection<NewsPoll> NewsPolls { get; set; }
        public virtual ICollection<PollsOption> PollsOptions { get; set; }
    }
}
