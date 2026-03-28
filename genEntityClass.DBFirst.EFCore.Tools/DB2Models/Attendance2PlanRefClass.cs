using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    /// <summary>
    /// 排班标准时间与班次关联表
    /// </summary>
    public partial class Attendance2PlanRefClass
    {
        public int Autoid { get; set; }
        /// <summary>
        /// 班次ID
        /// </summary>
        public int? Classid { get; set; }
        /// <summary>
        /// 计划ID
        /// </summary>
        public int? Planid { get; set; }
        /// <summary>
        /// 周期序号
        /// </summary>
        public int? PeriodNo { get; set; }
    }
}
