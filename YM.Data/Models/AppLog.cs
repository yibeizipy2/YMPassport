using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class AppLog
    {
        public int LogID { get; set; }
        public string ApplicationID { get; set; }
        public string Level { get; set; }
        public string LogTitle { get; set; }
        public string Message { get; set; }
        public string LoginUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> IsDispose { get; set; }
        public int LogType { get; set; }
        public virtual Application Application { get; set; }
    }
}
