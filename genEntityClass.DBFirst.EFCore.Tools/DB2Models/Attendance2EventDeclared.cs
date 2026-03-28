using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    public partial class Attendance2EventDeclared
    {
        /// <summary>
        /// 事件序号
        /// </summary>
        public int EventId { get; set; }
        /// <summary>
        /// 事件描述
        /// </summary>
        public string EventDescription { get; set; }
        /// <summary>
        /// 其它费用
        /// </summary>
        public decimal? Fee { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        public string CheckMan { get; set; }
        /// <summary>
        /// 经理签字
        /// </summary>
        public string Manager { get; set; }
        public int RecordId { get; set; }
        public bool IsBeginTime { get; set; }
    }
}
