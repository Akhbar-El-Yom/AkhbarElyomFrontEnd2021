using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class UserRole
    {
        public int? RoleId { get; set; }
        public int? AdminUserId { get; set; }
        public int? SectionId { get; set; }
        public int Id { get; set; }
        public int? JournalId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
