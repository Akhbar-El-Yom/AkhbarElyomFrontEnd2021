using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class NewsSection
    {
        public int NewsId { get; set; }
        public int SectionId { get; set; }

        public virtual MainSection Section { get; set; }
    }
}
