using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    /// <summary>
    /// 假日调休
    /// </summary>
    public partial class Attendance2Holiday
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Autoid { get; set; }
        /// <summary>
        /// 年份
        /// </summary>
        public int IYear { get; set; }
        /// <summary>
        /// 日期字符串yyyy-MM-dd
        /// </summary>
        public DateTime? SDate { get; set; }
        /// <summary>
        /// 节假日名称
        /// </summary>
        public string SName { get; set; }
        /// <summary>
        /// 上班时间字符串-hh:mm:ss.nnn
        /// </summary>
        public TimeSpan? BTime { get; set; }
        /// <summary>
        /// 下班时间字符串-hh:mm:ss.nnn
        /// </summary>
        public TimeSpan? ETime { get; set; }
        /// <summary>
        /// 节假日描述
        /// </summary>
        public string SDescription { get; set; }
    }
}
