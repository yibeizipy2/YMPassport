using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class Account
    {
        public Account()
        {
            this.AccountOrGroups = new List<AccountOrGroup>();
            this.AppAndUsers = new List<AppAndUser>();
            this.UserAndAccounts = new List<UserAndAccount>();
        }

        public int AccountID { get; set; }
        public string AccountTypeID { get; set; }
        public string Names { get; set; }
        public int AccountType { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public int IsLock { get; set; }
        public string Remark { get; set; }
        public int IsShow { get; set; }
        public virtual AccountType AccountType1 { get; set; }
        public virtual ICollection<AccountOrGroup> AccountOrGroups { get; set; }
        public virtual ICollection<AppAndUser> AppAndUsers { get; set; }
        public virtual ICollection<UserAndAccount> UserAndAccounts { get; set; }
    }
}
