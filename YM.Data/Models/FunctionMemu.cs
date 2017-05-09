using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class FunctionMemu
    {
        public FunctionMemu()
        {
            this.GroupPermissions = new List<GroupPermission>();
        }

        public string FunctionMemu1 { get; set; }
        public string ApplicationID { get; set; }
        public string Parent { get; set; }
        public Nullable<int> Depth { get; set; }
        public string Path { get; set; }
        public string FunctionCode { get; set; }
        public string Url { get; set; }
        public string Remark { get; set; }
        public Nullable<int> IsLock { get; set; }
        public Nullable<int> Sort { get; set; }
        public virtual Application Application { get; set; }
        public virtual ICollection<GroupPermission> GroupPermissions { get; set; }
    }
}
