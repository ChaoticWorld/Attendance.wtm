using System;
using System.Collections.Generic;

namespace em_wtm.DB2Models
{
    public partial class ReportPermission
    {
        public int Id { get; set; }
        public int? ReportId { get; set; }
        public int? UserId { get; set; }
    }
}
