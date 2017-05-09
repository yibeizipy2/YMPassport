using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class UserGroup
    {
        public UserGroup()
        {
            this.AccountOrGroups = new List<AccountOrGroup>();
            this.GroupPermissions = new List<GroupPermission>();
        }

        public int UserGroupID { get; set; }
        public string GroupName { get; set; }
        public string CreateMan { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Remark { get; set; }
        public int IsLock { get; set; }
        public virtual ICollection<AccountOrGroup> AccountOrGroups { get; set; }
        public virtual ICollection<GroupPermission> GroupPermissions { get; set; }
    }
}
