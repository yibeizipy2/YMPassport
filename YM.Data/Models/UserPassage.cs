using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class UserPassage
    {
        public int UserPassageID { get; set; }
        public string UserID { get; set; }
        public string PassageUserID { get; set; }
        public string UserName { get; set; }
        public int CommType { get; set; }
        public virtual User User { get; set; }
    }
}
