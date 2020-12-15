using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class MainSection
    {
        public MainSection()
        {
            NewsSections = new HashSet<NewsSection>();
        }

        public int SectionId { get; set; }
        public string SecTitle { get; set; }
        public byte? Hide { get; set; }
        public byte? WeeklySection { get; set; }
        public int? DisplayOrder { get; set; }
        public int? JournalId { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public int? AppDisplayOrder { get; set; }

        public int? ParentSectionId { get; set; }
        public virtual MainSection ParentSection { get; set; }

        public int? LevelNo { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual ICollection<MainSection> SubSections { get; set; }

        public virtual ICollection<NewsSection> NewsSections { get; set; }
        public virtual ICollection<TopNews> TopNews { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<NewsTicker> NewsTickers { get; set; }


    }
    public partial class SubSection : MainSection
    {
        public SubSection():base()
        {

        }
    }
}
