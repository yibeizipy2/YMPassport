using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class DepartmentPassage
    {
        public int DepartmentPassageID { get; set; }
        public string UserID { get; set; }
        public string DepartmentID { get; set; }
        public string Names { get; set; }
        public int CommType { get; set; }
        public virtual User User { get; set; }
    }
}
