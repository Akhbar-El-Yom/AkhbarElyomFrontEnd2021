using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class IssuesTopNews
    {
        public int NewsId { get; set; }
        public int IssueId { get; set; }
        public int DisplayOrder { get; set; }
        public int TopType { get; set; }
    }
}
