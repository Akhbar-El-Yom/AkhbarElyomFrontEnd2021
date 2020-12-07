using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class AdminUser
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? Type { get; set; }
        public DateTime? LastLive { get; set; }
        public string Telephone { get; set; }
        public string UserPhoto { get; set; }
        public string UserEmail { get; set; }
        public DateTime? BirthDay { get; set; }
        public string BirthPlace { get; set; }
        public string UserTwitter { get; set; }
        public string UserFb { get; set; }
        public int? Nationality { get; set; }
        public string EducationalQualification { get; set; }
        public string NickName { get; set; }
        public string AboutYourSelf { get; set; }
        public bool? Active { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
