using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    public partial class ReportScriptTypeEnum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 拼接参数的方法名
        /// </summary>
        public string Module { get; set; }
    }
}
