using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    public partial class ReportParam
    {
        public int Id { get; set; }
        public int? ReportId { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 对应数据表字段
        /// </summary>
        public string Field { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 操作符
        /// </summary>
        public string ParamOperator { get; set; }
        /// <summary>
        /// 缺省值
        /// </summary>
        public string DefaultValue { get; set; }
    }
}
