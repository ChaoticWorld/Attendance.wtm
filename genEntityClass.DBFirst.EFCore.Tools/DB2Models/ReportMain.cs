using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    public partial class ReportMain
    {
        public int ReportId { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
    }
}
