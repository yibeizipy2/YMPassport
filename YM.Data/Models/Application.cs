using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class Application
    {
        public Application()
        {
            this.AppAndUsers = new List<AppAndUser>();
            this.AppLogs = new List<AppLog>();
            this.FunctionMemus = new List<FunctionMemu>();
        }

        public string ApplicationID { get; set; }
        public string Names { get; set; }
        public string ApplicationCode { get; set; }
        public string Remark { get; set; }
        public int IsLock { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> MenuDepth { get; set; }
        public virtual ICollection<AppAndUser> AppAndUsers { get; set; }
        public virtual ICollection<AppLog> AppLogs { get; set; }
        public virtual ICollection<FunctionMemu> FunctionMemus { get; set; }
    }
}
