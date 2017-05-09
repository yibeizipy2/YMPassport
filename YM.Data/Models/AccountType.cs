using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            this.Accounts = new List<Account>();
        }

        public string AccountTypeID { get; set; }
        public string ApplicationID { get; set; }
        public string Names { get; set; }
        public string Remark { get; set; }
        public int IsLock { get; set; }
        public int DType { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
