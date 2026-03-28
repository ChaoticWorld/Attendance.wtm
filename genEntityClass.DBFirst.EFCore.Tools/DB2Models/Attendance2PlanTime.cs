using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    /// <summary>
    /// 排班标准时间
    /// </summary>
    public partial class Attendance2PlanTime
    {
        /// <summary>
        /// 计划id
        /// </summary>
        public int Planid { get; set; }
        /// <summary>
        /// 计划名
        /// </summary>
        public string PlanName { get; set; }
        /// <summary>
        /// 日期类型id
        /// </summary>
        public int? DayTypeId { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public TimeSpan? BTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public TimeSpan? ETime { get; set; }
    }
}
