using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class NewsCategory
    {
        public int CatId { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
