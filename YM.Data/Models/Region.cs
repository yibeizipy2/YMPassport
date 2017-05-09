using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class Region
    {
        public Region()
        {
            this.Departments = new List<Department>();
        }

        public string RegionID { get; set; }
        public string Names { get; set; }
        public string Spell { get; set; }
        public string Parent { get; set; }
        public int Depth { get; set; }
        public string Path { get; set; }
        public string ZipCode { get; set; }
        public string AreaCode { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> IsLock { get; set; }
        public string OtNames { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
