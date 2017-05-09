using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class Department
    {
        public Department()
        {
            this.Users = new List<User>();
        }

        public string DepartmenID { get; set; }
        public string RegionID { get; set; }
        public string Names { get; set; }
        public string Parent { get; set; }
        public int Depth { get; set; }
        public string Path { get; set; }
        public string Address { get; set; }
        public string LeaderName { get; set; }
        public string Tel { get; set; }
        public string Introduce { get; set; }
        public string TypeName { get; set; }
        public string MapX { get; set; }
        public string MapY { get; set; }
        public string Remark { get; set; }
        public int IsLock { get; set; }
        public string PingYinSx { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
