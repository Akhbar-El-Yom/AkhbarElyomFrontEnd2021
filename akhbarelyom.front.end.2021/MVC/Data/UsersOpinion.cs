using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class UsersOpinion
    {
        public int CommentId { get; set; }
        public int NewId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Messagebody { get; set; }
        public DateTime? Messagedate { get; set; }
        public byte Approved { get; set; }
        public int Views { get; set; }
        public byte? IsDeleted { get; set; }
        public string OperationalUser { get; set; }
        public string UserIp { get; set; }
        public string CloudIp { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
