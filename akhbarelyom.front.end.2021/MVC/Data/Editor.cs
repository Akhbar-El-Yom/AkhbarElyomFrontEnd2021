using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Editor
    {
        public int EditorId { get; set; }
        public string EditorName { get; set; }
        public int DisplayOrder { get; set; }
        public int JournalId { get; set; }
        public string Picture { get; set; }
        public int? SectionId { get; set; }
        public string ArticleName { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
