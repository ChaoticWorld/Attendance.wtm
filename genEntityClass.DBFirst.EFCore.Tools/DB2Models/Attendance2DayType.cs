using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    /// <summary>
    /// 日期类型
    /// </summary>
    public partial class Attendance2DayType
    {
        /// <summary>
        /// ID
        /// </summary>
        public int DayTypeId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string DayTypeName { get; set; }
        /// <summary>
        /// 显示
        /// </summary>
        public string DayTypeCaption { get; set; }
    }
}
