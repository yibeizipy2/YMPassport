using System;
using System.Collections.Generic;

namespace YM.Data.Models
{
    public partial class RapidFunction
    {
        public int RapidFunctionID { get; set; }
        public string FunctionCode { get; set; }
        public string Title { get; set; }
        public int IsOften { get; set; }
        public Nullable<int> ClickCount { get; set; }
        public string Remark { get; set; }
    }
}
