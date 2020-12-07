using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class LinkedNews
    {
        public int NewId { get; set; }
        public int JournalId { get; set; }
        public int SectionId { get; set; }
    }
}
