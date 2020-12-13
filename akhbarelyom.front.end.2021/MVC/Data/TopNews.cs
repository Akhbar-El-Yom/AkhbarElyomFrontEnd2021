using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class TopNews
    {
        public int NewsId { get; set; }
        public virtual News News { get; set; }
        public int SecId { get; set; }
        public virtual MainSection Section { get; set; }
        public int CatId { get; set; }
        public virtual NewsCategory NewsCategory { get; set; }
        public int DisplayOrder { get; set; }
        public int? JournalId { get; set; }
        public long Id { get; set; }
    }
}
