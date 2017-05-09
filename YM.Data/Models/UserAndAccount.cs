using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class UserAndAccount
    {
        public int UserAndAccountID { get; set; }
        public int Account { get; set; }
        public string UserID { get; set; }
        public virtual Account Account1 { get; set; }
        public virtual User User { get; set; }
    }
}
