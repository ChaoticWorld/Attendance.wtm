using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    /// <summary>
    /// 费用计算
    /// </summary>
    public partial class Attendance2FeeCalculator
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int FeeId { get; set; }
        /// <summary>
        /// 日期类型ID
        /// </summary>
        public string DayTypeId { get; set; }
        /// <summary>
        /// 时长范围A,A &gt; x &gt;= B
        /// </summary>
        public int? RangeA { get; set; }
        /// <summary>
        /// 时长范围B,A &gt; x &gt;= B
        /// </summary>
        public int? RangeB { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal? RangePrice { get; set; }
    }
}
