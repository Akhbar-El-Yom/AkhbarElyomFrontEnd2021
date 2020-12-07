using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class Rating
    {
        public int? ReviewerId { get; set; }
        public int? BookId { get; set; }
        public int? Rating1 { get; set; }
        public DateTime? RatingDate { get; set; }
    }
}
