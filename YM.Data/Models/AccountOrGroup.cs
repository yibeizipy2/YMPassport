using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class AccountOrGroup
    {
        public int AccountOrGroup1 { get; set; }
        public Nullable<int> UserGroupID { get; set; }
        public Nullable<int> AccountID { get; set; }
        public virtual Account Account { get; set; }
        public virtual UserGroup UserGroup { get; set; }
    }
}
