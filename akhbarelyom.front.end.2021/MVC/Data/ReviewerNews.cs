using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class ReviewerNews
    {
        public long Id { get; set; }
        public int? NewId { get; set; }
        public int? UserId { get; set; }
        public int? Done { get; set; }
        public DateTime? GetNewDate { get; set; }
    }
}
