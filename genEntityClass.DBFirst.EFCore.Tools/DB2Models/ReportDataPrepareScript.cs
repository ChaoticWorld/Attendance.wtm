using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    public partial class ReportDataPrepareScript
    {
        public int Id { get; set; }
        public int? ReportId { get; set; }
        /// <summary>
        /// 脚本
        /// </summary>
        public string Script { get; set; }
        /// <summary>
        /// 脚本类型ID
        /// </summary>
        public int? ScriptTypeId { get; set; }
        /// <summary>
        /// 脚本执行顺序
        /// </summary>
        public int? ScriptOrder { get; set; }
    }
}
