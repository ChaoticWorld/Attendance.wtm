using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    public partial class ReportParamOperatorEnum
    {
        public int Id { get; set; }
        /// <summary>
        /// 操作符
        /// </summary>
        public string Operator { get; set; }
        /// <summary>
        /// 提示
        /// </summary>
        public string OperatorTips { get; set; }
    }
}
