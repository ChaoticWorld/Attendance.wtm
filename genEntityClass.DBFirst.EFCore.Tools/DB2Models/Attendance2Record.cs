using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    public partial class Attendance2Record
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int RecordId { get; set; }
        /// <summary>
        /// 考勤机员工ID
        /// </summary>
        public int EmployeeId { get; set; }
        /// <summary>
        /// 方案班次ID
        /// </summary>
        public int? ClassId { get; set; }
        /// <summary>
        /// 周期内次序号
        /// </summary>
        public int? PeriodNo { get; set; }
        /// <summary>
        /// 日期字符串:yyyy-MM-dd
        /// </summary>
        public DateTime SDate { get; set; }
        /// <summary>
        /// b上班考勤时间字符串-hh:mm:ss.000
        /// </summary>
        public TimeSpan? BAttTime { get; set; }
        /// <summary>
        /// e下班考勤时间字符串-hh:mm:ss.000
        /// </summary>
        public TimeSpan? EAttTime { get; set; }
        /// <summary>
        /// b上班考勤偏移量（单位分钟：正为加班，负为早退）
        /// </summary>
        public int? BOffset { get; set; }
        /// <summary>
        /// e下班考勤偏移量（单位分钟：正为加班，负为早退）
        /// </summary>
        public int? EOffset { get; set; }
        public decimal? BOffsetFee { get; set; }
        public decimal? EOffsetFee { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public TimeSpan? BTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public TimeSpan? ETime { get; set; }
        /// <summary>
        /// 日期类型ID
        /// </summary>
        public int? DayTypeId { get; set; }
        /// <summary>
        /// 计划ID
        /// </summary>
        public int? Planid { get; set; }
    }
}
