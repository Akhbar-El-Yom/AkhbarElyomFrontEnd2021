using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Nationality
    {
        public short CountryId { get; set; }
        public string Name { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
