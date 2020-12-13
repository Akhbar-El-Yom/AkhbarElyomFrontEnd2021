using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MVC.Data
{
    public partial class NewsSection
    {
        [Key]
        public int NewsId { get; set; }
        public int SectionId { get; set; }

        public virtual MainSection Section { get; set; }
        public virtual News News { get; set; }

        //public virtual ICollection<News> News { get; set; }

        //public virtual ICollection<TopNews> TopNews { get; set; }


    }
}
