using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Profile
    {
        public int ProfileId { get; set; }
        public string ProfName { get; set; }
        public string MainPictureName { get; set; }
        public byte? Hide { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
