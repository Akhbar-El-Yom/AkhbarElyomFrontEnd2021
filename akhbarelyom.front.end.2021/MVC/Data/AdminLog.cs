using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class AdminLog
    {
        public int LogId { get; set; }
        public int? LogUserId { get; set; }
        public DateTime? LogDate { get; set; }
        public string LogUrl { get; set; }
        public string LogRemoteAddress { get; set; }
        public string LogServerName { get; set; }
        public string LogQueryString { get; set; }
    }
}
