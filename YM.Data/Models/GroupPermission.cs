using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class GroupPermission
    {
        public int GroupPermissionGroupID { get; set; }
        public Nullable<int> UserGroupID { get; set; }
        public string FunctionMemu { get; set; }
        public virtual FunctionMemu FunctionMemu1 { get; set; }
        public virtual UserGroup UserGroup { get; set; }
    }
}
