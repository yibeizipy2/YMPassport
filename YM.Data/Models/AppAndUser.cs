using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class AppAndUser
    {
        public string AppAndUserID { get; set; }
        public string ApplicationID { get; set; }
        public int Account { get; set; }
        public virtual Account Account1 { get; set; }
        public virtual Application Application { get; set; }
    }
}
