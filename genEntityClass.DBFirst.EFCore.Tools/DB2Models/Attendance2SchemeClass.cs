using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    /// <summary>
    /// 班次信息
    /// </summary>
    public partial class Attendance2SchemeClass
    {
        /// <summary>
        /// 班次名
        /// </summary>
        public string ClassName { get; set; }
        /// <summary>
        /// 班次id
        /// </summary>
        public int ClassId { get; set; }
        /// <summary>
        /// 总排班数
        /// </summary>
        public int? Periods { get; set; }
        /// <summary>
        /// 班次描述
        /// </summary>
        public string ClassDescription { get; set; }
        /// <summary>
        /// 班次内周期
        /// </summary>
        public int? ClassPeriods { get; set; }
    }
}
