using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class User
    {
        public User()
        {
            this.DepartmentPassages = new List<DepartmentPassage>();
            this.UserAndAccounts = new List<UserAndAccount>();
            this.UserPassages = new List<UserPassage>();
        }

        public string UserID { get; set; }
        public string DepartmenID { get; set; }
        public string UserCode { get; set; }
        public string UPassword { get; set; }
        public string Names { get; set; }
        public string PassportNo { get; set; }
        public string Tel { get; set; }
        public int IsLock { get; set; }
        public int UserType { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<DepartmentPassage> DepartmentPassages { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<UserAndAccount> UserAndAccounts { get; set; }
        public virtual ICollection<UserPassage> UserPassages { get; set; }
    }
}
