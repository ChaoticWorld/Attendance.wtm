using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    public partial class ReportScriptParam
    {
        public int Id { get; set; }
        public int? ScriptId { get; set; }
        public int? ParamId { get; set; }
    }
}
